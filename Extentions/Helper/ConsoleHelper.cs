using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Extentions
{
    public static class ConsoleHelper
    {
        // Fields
        public static bool IsOpen = false;

        // Methods
        [DllImport("kernel32.dll")]
        public static extern void AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern void FreeConsole();
        public static void OpenOrClose()
        {
            if (!IsOpen)
            {
                AllocConsole();
            }
            else
            {
                FreeConsole();
            }
            IsOpen = !IsOpen;
        }
    }
}
