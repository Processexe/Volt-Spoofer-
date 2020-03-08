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

namespace ToxicSpoofer
{
    class logs
    {
        public static void createFolders()
        {
            Directory.CreateDirectory("C:\\Logs\\SystemFiles\\");
            Directory.CreateDirectory("C:\\Logs\\System\\");
            Directory.CreateDirectory("C:\\Logs\\SystemDrivers\\");
            Directory.CreateDirectory("C:\\Logs\\ufi\\");
            Directory.CreateDirectory("C:\\Logs\\UAC\\");
            Directory.CreateDirectory("C:\\Logs\\graphicDrivers\\");
            Directory.CreateDirectory("C:\\Logs\\systemprofile\\");
        }
    }
}
