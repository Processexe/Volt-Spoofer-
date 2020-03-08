using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    class Settings
    {
        public static string AID = "853030";
        public static string Secret = "dKju0Wad046L9wHUsGNoo7qYv8sBz8SudLY";
        public static string Version = "1.0";
        public static string HWID()
        {
            return WindowsIdentity.GetCurrent().User.Value;
        }
        public static string Time()
        {
            string time = DateTime.Now.ToString("hh:mm tt MM/dd/yyyy");
                return time;
        }
}
}
