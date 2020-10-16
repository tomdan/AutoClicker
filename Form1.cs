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

        // to-click points list
        List<Point> cursor_coordinates_to_click = new List<Point>();
        int current_point_to_click = 0;

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

            // click key 1 to add new point to the list
            if (GetAsyncKeyState(49))
            {
                // add new point to the list
                cursor_coordinates_to_click.Add(new Point(MousePosition.X, MousePosition.Y));

                //add new point to the listBox
                points_to_click_listBox.Items.Add(cursor_coordinates_to_click[cursor_coordinates_to_click.Count-1]);
            }

            // click key 5 to reset the list
            if (GetAsyncKeyState(53))
            {
                // go to first point on the list
                current_point_to_click = 0;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            auto_clicker_timer.Enabled = true;
        }

        private void auto_clicker_timer_Tick(object sender, EventArgs e)
        {
            if (current_point_to_click < cursor_coordinates_to_click.Count() )
            {
                // set the cursor on the next point of the list
                SetCursorPos(cursor_coordinates_to_click[current_point_to_click].X, cursor_coordinates_to_click[current_point_to_click].Y);

                // left click of the mouse
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                // go to the next point of the list
                current_point_to_click++;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            // clear list of points to clicked
            cursor_coordinates_to_click.Clear();

            // clear listBox
            points_to_click_listBox.Items.Clear();
        }
    }
}
