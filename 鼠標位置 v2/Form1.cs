using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鼠標位置_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyboardHook.GlobalKeyDown += KeyboardHook_GlobalKeyDown;
        }

        #region define
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        const int MouseEvent_MOVE = 0x0001;
        const int MouseEvent_LEFTDOWN = 0x0002;
        const int MouseEvent_LEFTUP = 0x0004;
        const int MouseEvent_RIGHTDOWN = 0x0008;
        const int MouseEvent_RIGHTUP = 0x0010;
        const int MouseEvent_MIDDLEDOWN = 0x0020;
        const int MouseEvent_MIDDLEUP = 0x0040;
        const int MouseEvent_ABSOLUTE = 0x8000;
        #endregion

        int clickCount = 0;
        bool keepGoing = false;

        string showPosition(Point position) => $"( {position.X} , {position.Y} )";

        private void KeyboardHook_GlobalKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    keepGoing = false;
                    break;
                case Keys.F3:
                    mouseClickInfinity_Click(null, null);
                    break;
                case Keys.F12:
                    Process.Start(Environment.CurrentDirectory);
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            mouseLocation.Text = showPosition(MousePosition);
            clientLocation.Text = showPosition(Location);
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e) => TopMost = topMostCheckBox.Checked;

        private void opacityTrack_Scroll(object sender, EventArgs e) => opacityDisplay.Text = $"{(Opacity = opacityTrack.Value * .05) * 100:f0}%";

        private void returnPosition_Click(object sender, EventArgs e) => Location = Cursor.Position = new Point(0, 0);

        private void mouseClickInfinity_Click(object sender, EventArgs e)
        {
            keepGoing = topMostCheckBox.Checked = true;
            while (keepGoing)
            {
                mouseClickCount.Text = (clickCount += 1).ToString();
                Application.DoEvents();
                Thread.Sleep(1000);
                _ = mouseClick(MousePosition);
            }
        }

        async Task mouseClick(Point position)
        {
            SetCursorPos(position.X, position.Y);
            await Task.Run(() =>
            {
                mouse_event(MouseEvent_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MouseEvent_LEFTUP, 0, 0, 0, 0);
            });
        }
    }
}

