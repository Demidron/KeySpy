using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHooks.Methods
{
    public enum HookTypes : Int32
    {
        WH_MOUSE = 7,
        WH_MOUSE_LL = 14,
        WH_KEYBOARD_LL = 13,
        WH_KEYBOARD = 2
    }
    public enum HookMessages : Int32
    {
        WM_KEYDOWN = 0x0100,
        WM_KEYUP = 0x0101
    }
}
