using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.CLASS
{
    public static class User_cache
    {
        public static string Username;
        public static string Password;

        public static void GetAdmin(string username,string password)
        {
            Username = username;
            Password = password;
        }
    }
}
