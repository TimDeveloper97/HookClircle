using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookCircleWD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        #region ======================= PROPERTIES ========================
        private List<Keys> startKeys, stopKeys;
        private static bool IsHookStart, IsHookStop;

        #endregion ====================================================

        #region ======================= METHODS ========================
        void Init()
        {
            startKeys = new List<Keys>();
            stopKeys = new List<Keys>();

            IsHookStart = IsHookStop = false;
        }
        #endregion ====================================================


        #region ======================= EVENTS ========================

        private void btnHookStart_Click(object sender, EventArgs e)
        {
            IsHookStart = true;
            startKeys?.Clear();
        }

        private void btnHookStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsHookStart)
            {
                return;
            }

            startKeys.Add(e.KeyCode);
        }

        private void btnHookStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (!IsHookStart) return;

            IsHookStart = false;
            btnHookStart.Text = startKeys.ExtendedToString();
        }
        private void btnHookStop_Click(object sender, EventArgs e)
        {
            IsHookStop = true;
            stopKeys?.Clear();
        }

        private void btnHookStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsHookStop)
            {
                return;
            }

            stopKeys.Add(e.KeyCode);
        }

        private void btnHookStop_KeyUp(object sender, KeyEventArgs e)
        {
            if (!IsHookStop) return;

            IsHookStop = false;
            btnHookStop.Text = stopKeys.ExtendedToString();
        }
        #endregion ====================================================
    }
}
