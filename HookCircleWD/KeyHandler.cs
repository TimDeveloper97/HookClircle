using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookCircleWD
{
    public class KeyHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int key;
        private IntPtr hWnd;
        //private int id;

        public KeyHandler(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32();
        }

        public bool Register(int id, int modifier, int key)
        {
            return RegisterHotKey(hWnd, id, modifier, key);
        }

        public bool Unregiser(int id)
        {
            return UnregisterHotKey(hWnd, id);
        }
    }

    public static class Constants
    {
        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;

        public const int Alt = 18; 
        public const int ArrowDown = 40; 
        public const int ArrowLeft = 37; 
        public const int ArrowRight = 39; 
        public const int ArrowUp = 38; 
        public const int Backspace = 8; 
        public const int CapsLock = 20; 
        public const int Ctrl = 17; 
        public const int Delete = 46; 
        public const int End = 35; 
        public const int Enter = 13; 
        public const int F1 = 112; 
        public const int F2 = 113; 
        public const int F3 = 114; 
        public const int F4 = 115; 
        public const int NumPad0 = 96; 
        public const int NumPad1 = 97; 
        public const int NumPad2 = 98; 
        public const int NumPad3 = 99; 
        public const int NumPad4 = 100; 
        public const int NumPad5 = 101; 
        public const int NumPad6 = 102; 
        public const int NumPad7 = 103; 
        public const int NumPad8 = 104; 
        public const int NumPad9 = 105; 
        public const int PageDown = 34; 
        public const int PageUp = 33; 
        public const int Pause = 19; 
        public const int PrintScrn = 0x2C; 
        public const int ScrollLock = 145; 
        public const int Shift = 16; 
        public const int Spacebar = 32; 
        public const int Tab = 9; 
    }

    //public class Point
    //{
    //    public int X;
    //    public int Y;
    //}

    public enum Half
    {
        Upper = 1,
        Lower = -1,
    }
}
