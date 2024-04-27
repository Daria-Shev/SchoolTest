using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WebSerCore.Class;
using WebSerCore.Controllers;
using Microsoft.Data.SqlClient;
using System.Collections.Specialized;


var adminRole = new Role("teacher");
var userRole = new Role("student");

//var people = new List<UserAccount>
//{
//    new UserAccount { nickname = "teacher", password = "password", user_account_type = "teacher", full_name = "Teacher Name" },
//    new UserAccount { nickname = "student", password = "password", user_account_type = "student", full_name = "Student Name" },
//};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/login";
        options.AccessDeniedPath = "/accessdenied";
    });
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.Map("/accessdenied", async (HttpContext context) =>
{
    context.Response.StatusCode = 403;
    var message = new Message { message = "У вас нема доступу" };
    return Results.BadRequest(message);
    //await context.Response.WriteAsJsonAsync(message);

    //await context.Response.WriteAsJsonAsync(new { Message = "У вас нема доступу" });
});

// Обновленный код для обработки /login
app.Map("/login", async (HttpContext context) =>
{
    var nickname = context.Request.Query["nickname"];
    var password = context.Request.Query["password"];

    if (string.IsNullOrEmpty(nickname) || string.IsNullOrEmpty(password))
        return Results.BadRequest(new { Message = "Нікнейм та/або пароль не встановлені" });

    UserAccount? user = InfoUser(nickname, password);

    //if (user is null) return Results.Unauthorized();
    if (user is null) return Results.BadRequest(new { Message = "Такого користувача не знайдено" });

    var claims = new List<Claim>
    {
        new Claim(ClaimsIdentity.DefaultNameClaimType, user.nickname),
        new Claim(ClaimsIdentity.DefaultRoleClaimType, user.user_account_type)
    };

    var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

    // Здесь мы создаем AuthenticationProperties для управления параметрами аутентификации, 
    // включая куки и другие параметры.
    var authenticationProperties = new AuthenticationProperties
    {
        IsPersistent = true, // Здесь вы можете установить, насколько долго куки будут сохранены
        ExpiresUtc = DateTimeOffset.UtcNow.AddHours(3) // Куки будут действительными в течение 3 часов
    };

    await context.SignInAsync(claimsPrincipal, authenticationProperties);


    // Возвращаем кастомный объект или сообщение. 
    // Можете также вернуть какой-то JSON, если клиент ожидает этот формат ответа.
    // return Results.Ok(  context.Response.Headers["Set-Cookie"] );
    //return Results.Ok(new { Message = "Авторизація успішна", Cookies = context.Response.Headers["Set-Cookie"] });
    var message = new Message { message = "Авторизація успішна" };
    return Results.Ok(message);
});

UserAccount InfoUser(string nickname, string password)
{
    UserAccount userAccount = null;
    BD bd = new BD();
    bd.connectionBD();
    string sqlExpression = "SELECT nickname, password, user_account_type, full_name FROM user_account WHERE nickname = @Nickname AND password=@Password";
    using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
    {
        command.Parameters.AddWithValue("@Nickname", nickname);
        command.Parameters.AddWithValue("@Password", password);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                userAccount = new UserAccount()
                {
                    nickname = reader["nickname"].ToString(),
                    password = reader["password"].ToString(),
                    user_account_type = reader["user_account_type"].ToString().TrimEnd(),
                    full_name = reader["full_name"].ToString().TrimEnd()
                };

            }

        }
    }

    bd.closeBD();
    return userAccount;
}

//app.Map("/teacher", [Authorize(Roles = "teacher")] () => "Teacher Panel");
//app.Map("/student", [Authorize(Roles = "student")] () => "Student Panel");

app.Map("/", (HttpContext context) =>
{
    var login = context.User.FindFirst(ClaimsIdentity.DefaultNameClaimType);
    var role = context.User.FindFirst(ClaimsIdentity.DefaultRoleClaimType);

    return $"Name: {login?.Value}\nRole: {role?.Value}";
});

app.MapGet("/logout", async (HttpContext context) =>
{
    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    var message = new Message { message = "Ви вийшли з акаунту" };
    return message;
});

app.MapControllers();

app.Run();
