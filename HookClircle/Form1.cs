using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookClircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init();
        }

        //======================= METHODS ========================
        void Init()
        {

        }

        private KeyMessageFilter m_filter = new KeyMessageFilter();
        void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {

            Console.WriteLine(args.Key.ToString());
            if (lastKey == Key.LeftCtrl && args.Key == Key.C)
            {
                MessageBox.Show(args.Key.ToString());
            }
            lastKey = args.Key;
        }

        //=========================================================


        //======================= EVENTS ========================
        private void btnHookStart_Click(object sender, EventArgs e)
        {

        }

        private void btnHookStop_Click(object sender, EventArgs e)
        {

        }

        private void btnHookState_Click(object sender, EventArgs e)
        {

        }

        //=========================================================
    }
}
