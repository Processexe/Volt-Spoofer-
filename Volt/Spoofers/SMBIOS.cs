using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToxicSpoofer
{
    class SMBIOS
    {

        public static string RandomString(int length)
        {
            return new string((from s in Enumerable.Repeat<string>("0123456789", length)
                               select s[SMBIOS.random.Next(s.Length)]).ToArray<char>());
        }

        private static Random random = new Random();
    }
}
