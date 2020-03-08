using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using ArmDot.Client;

namespace ToxicSpoofer
{
    class Spoofer
    {
        private static void RunBios(String dir)
        {
            Process pa = new Process();
            pa.StartInfo.RedirectStandardInput = true;
            pa.StartInfo.RedirectStandardError = false;
            pa.StartInfo.RedirectStandardOutput = false;
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.CreateNoWindow = true;
            pa.StartInfo.FileName = @"cmd.exe";
            pa.StartInfo.Arguments = "-R C:\\";
            pa.Start();
            Thread.Sleep(80);
            pa.StandardInput.WriteLine(@"" + dir);
            Thread.Sleep(120);
            pa.Kill();
            pa.Close();
        }

        public static string DiskdriveCheck()
        {

            string text = "";
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
                foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
                {
                    ManagementObject managementObject = (ManagementObject)managementBaseObject;
                    try
                    {
                        text += managementObject["SerialNumber"].ToString();
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
            if (text == "")
            {
            }
            return text;
        }

        public static void ExecuteCommand(string command)
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            });
            process.WaitForExit();
            string text = process.StandardOutput.ReadToEnd();
            string text2 = process.StandardError.ReadToEnd();
            int exitCode = process.ExitCode;
            process.Close();
        }

        public static void Diskdrive()
        {
            Extractor();
            Process RegClean = new Process();
            RegClean.StartInfo.FileName = "cmd.exe";
            RegClean.StartInfo.RedirectStandardInput = true;
            RegClean.StartInfo.RedirectStandardError = true;
            RegClean.StartInfo.RedirectStandardOutput = true;
            RegClean.StartInfo.UseShellExecute = false;
            RegClean.StartInfo.CreateNoWindow = true;
            RegClean.Start();
            RegClean.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im BEService.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
            RegClean.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            RegClean.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            RegClean.StandardInput.WriteLine("exit");
            Process cmd9 = new Process();
            cmd9.StartInfo.FileName = "cmd.exe";
            cmd9.StartInfo.RedirectStandardInput = true;
            cmd9.StartInfo.RedirectStandardOutput = false;
            cmd9.StartInfo.RedirectStandardError = false;
            cmd9.StartInfo.UseShellExecute = false;
            cmd9.StartInfo.CreateNoWindow = true;
            cmd9.Start();
            cmd9.StandardInput.WriteLine("cd C:\\Program Files");
            cmd9.StandardInput.WriteLine("mapper.exe driver.sys");
            cmd9.StandardInput.WriteLine("exit");
            Thread.Sleep(4000);
            Spoofer.ExecuteCommand("net stop IPHLPSVC");
            Thread.Sleep(500);
            Spoofer.ExecuteCommand("net stop winmgmt");
            Spoofer.ExecuteCommand("net start winmgmt");
            Spoofer.ExecuteCommand("sc stop winmgmt");
            Spoofer.ExecuteCommand("sc start winmgmt");
            Spoofer.ExecuteCommand("net start IPHLPSVC");
            File.Delete("C:\\Program Files\\mapper.exe");
            File.Delete("C:\\Program Files\\driver.sys");
            System.Windows.Forms.MessageBox.Show("yeet done", "Volt-spoofer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            return new string((from s in Enumerable.Repeat<string>("abcdefghilmnopqrstuvzABCDEFGHILMNOPQRSTUVZ0123456789", length)
                               select s[ToxicSpoofer.Spoofer.random.Next(s.Length)]).ToArray<char>());
        }

        public static void Bios()
        {
            {
                Extractor();
                string exe = @"C:\Program Files\AMIDEWINx64.exe";
                string sys = @"C:\Program Files\amifldrv64.sys";
                Process process = new Process();
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = "cmd.exe";
                process.Start();
                process.StandardInput.WriteLine("cd C:\\Program Files");
                process.StandardInput.WriteLine("AMIDEWINx64.exe /BS " + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("AMIDEWINx64.exe /SS " + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("AMIDEWINx64.exe /SU " + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("AMIDEWINx64.exe /SK " + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("AMIDEWINx64.exe /SF " + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("AMIDEWINx64.exe /CS " + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("AMIDEWINx64.exe /PSN" + "toxic-" + Spoofer.RandomString(8));
                process.StandardInput.WriteLine("exit");
                process.WaitForExit();
                File.Delete("C:\\Program Files\\AMIDEWINx64.exe");
                File.Delete("C:\\Program Files\\amifldrv64.sys");
            }
        }
        public static void Extractor()
        {

            byte[] exeBytes6 = ToxicSpoofer.Properties.Resources.driver;
            string exeToRun6 = @"C:\Program Files\driver.sys";
            byte[] exeBytes2 = ToxicSpoofer.Properties.Resources.mapper;
            string exeToRun2 = @"C:\Program Files\mapper.exe";
            byte[] exeBytes10 = ToxicSpoofer.Properties.Resources.AMIDEWINx64;
            string exeToRun10 = @"C:\Program Files\AMIDEWINx64.exe";
            byte[] exeBytes11 = ToxicSpoofer.Properties.Resources.amifldrv64;
            string exeToRun11 = @"C:\Program Files\amifldrv64.sys";

            using (FileStream exeFile2 = new FileStream(exeToRun2, FileMode.Create))
            {
                exeFile2.Write(exeBytes2, 0, exeBytes2.Length);
            }
            using (FileStream exeFile2 = new FileStream(exeToRun2, FileMode.Create))
            {
                exeFile2.Write(exeBytes2, 0, exeBytes2.Length);
            }
            using (FileStream exeFile11 = new FileStream(exeToRun11, FileMode.Create))
            {
                exeFile11.Write(exeBytes11, 0, exeBytes11.Length);
            }
            using (FileStream exeFile10 = new FileStream(exeToRun10, FileMode.Create))
            {
                exeFile10.Write(exeBytes10, 0, exeBytes10.Length);
            }

            using (FileStream exeFile6 = new FileStream(exeToRun6, FileMode.Create))
            {
                exeFile6.Write(exeBytes6, 0, exeBytes6.Length);
            }

        }
        public static void ExtactorDel()
        {
            File.Delete("C:\\Program Files\\driver.sys");
            File.Delete("C:\\Program Files\\mapper.exe");
            File.Delete("C:\\Program Files\\AMIDEWINx64.exe");
            File.Delete("C:\\Program Files\\amifldrv64.sys");
        }
    }
}
