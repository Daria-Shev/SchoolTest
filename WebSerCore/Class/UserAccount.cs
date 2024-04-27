namespace WebSerCore.Class
{
    public class UserAccount
    {
        public string nickname { get; set; }
        public string password { get; set; }
        public string user_account_type { get; set; }
        public string full_name { get; set; }

    }
    class Role : UserAccount
    {
        public string Name { get; set; }
        public Role(string name) => Name = name;
    }
    public class Message 
    { 
        public string message { get; set; }
    }
}
