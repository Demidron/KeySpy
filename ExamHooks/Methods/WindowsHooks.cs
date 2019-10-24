using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamHooks.Methods;

namespace ExamHooks.Methods
{
    public static class WindowsHooks
    {
        public static int GetHook(HookTypes hookType, HookProc hookProc)
        {
            int hHook = WinApiMethods.SetWindowsHookEx((int)hookType, hookProc,
            Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
            return hHook;
        }

    }

    public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);
}
