using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

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
        private const float MOUSE_SMOOTH = 200f;
        private Keys startKey, stopKey;
        private static bool IsHookStart, IsHookStop;
        private KeyHandler startGhk, stopGhk;
        private static List<Point> Points;
        private System.Timers.Timer timer;
        private static bool isStop;

        #endregion ====================================================

        #region ======================= METHODS ========================
        void Init()
        {
            btnHookState.Text = "START";
            IsHookStart = IsHookStop = false;
            isStop = false;
            Points = new List<Point>();

            // get points
            GetPointsCircle();
        }

        private void HandleHotkey(Message m)
        {
            var key = m.WParam.ToInt32();
            Console.WriteLine($"Hot key press: [{key}]");

            if (key == 1)
            {
                btnHookState.Text = "STOP";
                isStop = false;
                Task.Run(() => { while (true) ExecuteDrawPoints(); });
            }
            else if (key == 2)
            {
                btnHookState.Text = "START";
                isStop = true;
            }
        }

        Point GetCenter()
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;

            var i = new Point(x / 2, y / 2);
            return i;
        }

        double GetY(double x, Half half, double radius, Point center)
        {
            var tY = Math.Sqrt(radius * radius - Math.Pow((x - center.X), 2));
            return tY * (int)half + center.Y;
        }

        void GetPointsCircle()
        {
            var center = GetCenter();
            var radius = (int)nRadius.Value;

            // upper half
            for (double x = center.X + (-1.0) * radius; x <= radius + center.X; x += 1)
            {
                var y = (int)GetY(x, Half.Upper, radius, center);
                Points.Add(new Point((int)x, y));
            }

            // lower half
            for (double x = radius + center.X - 1; x >= (-1.0) * radius + center.X; x -= 1)
            {
                Points.Add(new Point((int)x, (int)GetY(x, Half.Lower, radius, center)));
            }
        }

        void ExecuteDrawPoints()
        {
            for (int i = 0; i < Points.Count; i += 50)
            {
                if (isStop) break;

                MoveTo(Points[i].X, Points[i].Y);
            }
        }

        void MoveTo(int targetX, int targetY)
        {
            var targetPosition = new Point(targetX, targetY);
            var curPos = Cursor.Position;

            var diffX = targetPosition.X - curPos.X;
            var diffY = targetPosition.Y - curPos.Y;

            if (isStop) return;

            for (int i = 0; i <= MOUSE_SMOOTH; i++)
            {
                float x = curPos.X + (diffX / MOUSE_SMOOTH * i);
                float y = curPos.Y + (diffY / MOUSE_SMOOTH * i);
                Cursor.Position = new Point((int)x, (int)y);

                Thread.Sleep(1);
                if (isStop) return;
            }

            if (Cursor.Position != targetPosition)
            {
                MoveTo(targetPosition.X, targetPosition.Y);
            }
        }

        #endregion ====================================================


        #region ======================= EVENTS ========================

        private void btnHookStart_Click(object sender, EventArgs e)
        {
            IsHookStart = true;
            startKey = new Keys();
        }

        private void btnHookStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsHookStart)
            {
                return;
            }

            startKey = e.KeyCode;
        }

        private void btnHookStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (!IsHookStart) return;

            IsHookStart = false;

            btnHookStart.Text = startKey.ToString();

            //register
            if (startGhk != null)
                startGhk.Unregiser(1);

            startGhk = new KeyHandler(startKey, this);
            startGhk.Register(1, 0, (int)startKey);
        }

        private void btnHookStop_Click(object sender, EventArgs e)
        {
            IsHookStop = true;
            stopKey = new Keys();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey(m);
            base.WndProc(ref m);
        }

        private void btnHookStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsHookStop)
            {
                return;
            }

            stopKey = e.KeyCode;
        }

        private void btnHookStop_KeyUp(object sender, KeyEventArgs e)
        {
            if (!IsHookStop) return;

            IsHookStop = false;
            btnHookStop.Text = stopKey.ToString();

            //register
            if (stopGhk != null)
                startGhk.Unregiser(2);

            stopGhk = new KeyHandler(stopKey, this);
            stopGhk.Register(2, 0, (int)stopKey);
        }

        #endregion ====================================================
    }
}
