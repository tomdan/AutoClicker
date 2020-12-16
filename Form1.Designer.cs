namespace AutoClicker
{
    partial class AutoClickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.cursor_coordinates_timer = new System.Windows.Forms.Timer(this.components);
            this.cursor_coordinates_label = new System.Windows.Forms.Label();
            this.auto_clicker_timer = new System.Windows.Forms.Timer(this.components);
            this.points_to_click_listBox = new System.Windows.Forms.ListBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Location = new System.Drawing.Point(0, 0);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(80, 40);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // cursor_coordinates_timer
            // 
            this.cursor_coordinates_timer.Enabled = true;
            this.cursor_coordinates_timer.Interval = 200;
            this.cursor_coordinates_timer.Tick += new System.EventHandler(this.cursor_coordinates_timer_Tick);
            // 
            // cursor_coordinates_label
            // 
            this.cursor_coordinates_label.AutoSize = true;
            this.cursor_coordinates_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cursor_coordinates_label.ForeColor = System.Drawing.Color.Ivory;
            this.cursor_coordinates_label.Location = new System.Drawing.Point(7, 46);
            this.cursor_coordinates_label.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cursor_coordinates_label.Name = "cursor_coordinates_label";
            this.cursor_coordinates_label.Size = new System.Drawing.Size(268, 18);
            this.cursor_coordinates_label.TabIndex = 1;
            this.cursor_coordinates_label.Text = "Współrzędne kursora: 0 , 0";
            // 
            // auto_clicker_timer
            // 
            this.auto_clicker_timer.Interval = 1000;
            this.auto_clicker_timer.Tick += new System.EventHandler(this.auto_clicker_timer_Tick);
            // 
            // points_to_click_listBox
            // 
            this.points_to_click_listBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.points_to_click_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.points_to_click_listBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.points_to_click_listBox.ForeColor = System.Drawing.Color.White;
            this.points_to_click_listBox.FormattingEnabled = true;
            this.points_to_click_listBox.ItemHeight = 19;
            this.points_to_click_listBox.Location = new System.Drawing.Point(657, 0);
            this.points_to_click_listBox.Name = "points_to_click_listBox";
            this.points_to_click_listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.points_to_click_listBox.Size = new System.Drawing.Size(100, 461);
            this.points_to_click_listBox.TabIndex = 2;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clear_button.Location = new System.Drawing.Point(86, 0);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(80, 40);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Wyczyść";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DimGray;
            this.panel_top.Controls.Add(this.button_exit);
            this.panel_top.Controls.Add(this.button_minimize);
            this.panel_top.Controls.Add(this.start_button);
            this.panel_top.Controls.Add(this.clear_button);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(657, 40);
            this.panel_top.TabIndex = 4;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(617, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(40, 40);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_minimize.ForeColor = System.Drawing.Color.Orange;
            this.button_minimize.Location = new System.Drawing.Point(575, 0);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(1);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(40, 40);
            this.button_minimize.TabIndex = 4;
            this.button_minimize.Text = "---";
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // AutoClickerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(757, 461);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.points_to_click_listBox);
            this.Controls.Add(this.cursor_coordinates_label);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoClickerForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.TopMost = true;
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer cursor_coordinates_timer;
        private System.Windows.Forms.Label cursor_coordinates_label;
        private System.Windows.Forms.Timer auto_clicker_timer;
        private System.Windows.Forms.ListBox points_to_click_listBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_exit;
    }
}

