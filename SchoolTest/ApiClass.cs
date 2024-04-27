using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using SchoolTest.Info;
using SchoolTest.Helpers;

namespace SchoolTest
{
    public class ApiClass
    {
        UriBuilder uriBuilder = new UriBuilder();
        public NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);
        public string address = "localhost";
        public int port = 44382;

        public string path = string.Empty;
        public Uri url;
        public void uriCreate()
        {
            uriBuilder.Scheme = "https";
            uriBuilder.Host = address;
            uriBuilder.Port = port;
            uriBuilder.Path = path;
            uriBuilder.Query = query.ToString();
            url = uriBuilder.Uri;
        }


        public object GetServerResult()
        {
            if (User.cookie != null)
            {
                User.ServerClient.DefaultRequestHeaders.Add("Cookie", User.cookie);
            }

            HttpResponseMessage authenticationResponse = User.ServerClient.GetAsync(url).Result;
            var streamContent = authenticationResponse.Content.ReadAsStreamAsync().Result;

            //return streamContent;

            //if (authenticationResponse.IsSuccessStatusCode)
            {
                return streamContent;
            }
            //else
            //{
            //    byte[] byteArray = Encoding.UTF8.GetBytes("Помилка: " + authenticationResponse.ReasonPhrase);
            //    return new MemoryStream(byteArray);
            //}
        }
        public void createClient()
        {
            User.cookieContainer = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = User.cookieContainer;
            User.ServerClient = new HttpClient(handler);
            User.ServerClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void exit()
        {
            url = new Uri("https://localhost:44382/logout");
            var Stream = GetServerResult();
            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            SchoolTest.ProgramForms.Message.MessageInfo(message.message);
        }

        public object ServerAuthorization()
        {
            HttpResponseMessage authenticationResponse = User.ServerClient.GetAsync(url).Result;
            var responseCookies = User.cookieContainer.GetCookies(url).Cast<Cookie>();
            var cookie = responseCookies.FirstOrDefault(x => x.Name == ".AspNetCore.Cookies");

            if (cookie != null)
            {
                User.cookie = cookie.Name + "=" + cookie.Value;
            }
            var streamContent = authenticationResponse.Content.ReadAsStreamAsync().Result;
            return streamContent;
        }

    }

}
