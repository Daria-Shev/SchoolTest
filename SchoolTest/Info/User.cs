using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest.Info
{
    public static class User
    {
        public static string cookie = null;
        public static string nicname;
        public static string full_name;
        public static CookieContainer cookieContainer;
        public static HttpClient ServerClient;
    }
    public class MessageString
    {
        public string message;
    }
}
