using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClickerForm : Form
    {
        //to using keyboard without form focus
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool GetAsyncKeyState(int vKey);

        //to using mouse cursor
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        //to using mouse click
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        // mouse buttons
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public AutoClickerForm()
        {
            InitializeComponent();
        }

        private void cursor_coordinates_timer_Tick(object sender, EventArgs e)
        {
            // write the current cursor position to the label
            cursor_coordinates_label.Text = "Współrzędne kursora: " + MousePosition.X.ToString() + " , " + MousePosition.Y.ToString();

            // click Q key to turn off auto clicker timer 
            if (GetAsyncKeyState(81))
            {
                auto_clicker_timer.Enabled = false;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            auto_clicker_timer.Enabled = true;
        }

        private void auto_clicker_timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
