using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ArmDot.Client;
using System.Net;
using Outbuilt;

namespace ToxicSpoofer
{
    class Program
    {


        [VirtualizeCode]
        public static void Timex()
        {
            purple();
            Console.Write(" [");
            DateTime now = DateTime.Now;
            Console.Write(now);
            Console.Write("]");
        }
        [VirtualizeCode]
        public static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        [VirtualizeCode]
        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        [VirtualizeCode]
        public static void Orange()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        [VirtualizeCode]
        public static void purple()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        static void Main(string[] args)
        {
            Auth.Handler.Initialize();
            if (Auth.ProgramInfo.Freemode == "Enabled")
            {
                Console.WriteLine("This application is in freemode redirecting!");
            }
            Console.Clear();
            draw.logo();
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("] ");
            Console.WriteLine("Key:");
            string key = Console.ReadLine();
            bool allin1 = Auth.Handler.Login_Register_Redeem_With_Key(key);
            if (allin1)
            {
                WebClient webClient = new WebClient();
                try
                {
                    Outbuilt.Protection.Start();
                    Console.Clear();

                    draw.logo(); Console.WriteLine("");

                    try
                    {
                        Outbuilt.Protection.Start();
                        Console.WriteLine("");
                        Green(); Console.WriteLine(" Press enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        Outbuilt.Protection.Start();
                        draw.logo();
                        Console.WriteLine("");
                        Orange(); Console.WriteLine(" Initializing Toxic...");
                        Outbuilt.Protection.Start();
                        Console.WriteLine("");
                        Timex(); White(); Console.WriteLine(" Cleaning tracking files...");
                        Outbuilt.Protection.Start();
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
                        RegClean.StandardInput.WriteLine("");
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
                        Outbuilt.Protection.Start();
                        Cleaners.ModifyRegistry();
                        Outbuilt.Protection.Start();
                        Cleaners.OnlineCleanRegs();
                        Outbuilt.Protection.Start();
                        Cleaners.ExtraClean();
                        Outbuilt.Protection.Start();
                        Cleaners.FileCleaner();
                        Outbuilt.Protection.Start();
                        Cleaners.OnlineCleanTraces();
                        Outbuilt.Protection.Start();
                        Cleaners.FeggotCleaner();
                        Outbuilt.Protection.Start();
                        Timex(); Green(); Console.WriteLine(" System tracking files/regs cleaned.");
                        Outbuilt.Protection.Start();
                        Console.WriteLine("");
                        Timex(); White(); Console.WriteLine(" Spoofing network instance's...");
                        Outbuilt.Protection.Start();
                        MAC.SpoofMAC();
                        Timex(); Green(); Console.WriteLine(" Network instance's spoofed.");
                        Outbuilt.Protection.Start();
                        Console.WriteLine("");
                        Timex(); White(); Console.WriteLine(" Spoofing HWID instance's...");
                        Outbuilt.Protection.Start();
                        Spoofer.Diskdrive();
                        Outbuilt.Protection.Start();
                        Spoofer.Bios();
                        Outbuilt.Protection.Start();
                        Timex(); Green(); Console.WriteLine(" HWID instance's spoofed");
                        Outbuilt.Protection.Start();
                        Thread.Sleep(4000);
                    } catch
                    {
                        MessageBox.Show("An error was occurred. Please contact Volt.exe#0001");
                    }
                    Environment.Exit(0);
                else
                    {
                        Console.WriteLine("Key is invalid!");
                    }
                    Console.ReadLine();

                }catch
                {
                    MessageBox.Show("Error!");
                }
            }
        }
    }
}
