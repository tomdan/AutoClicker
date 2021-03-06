﻿namespace AutoClicker
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
            this.minimize_button = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_of_keys_actions = new System.Windows.Forms.Timer(this.components);
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.start_button.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.cursor_coordinates_timer.Interval = 50;
            this.cursor_coordinates_timer.Tick += new System.EventHandler(this.cursor_coordinates_timer_Tick);
            // 
            // cursor_coordinates_label
            // 
            this.cursor_coordinates_label.AutoSize = true;
            this.cursor_coordinates_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cursor_coordinates_label.ForeColor = System.Drawing.Color.Gold;
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
            this.points_to_click_listBox.Location = new System.Drawing.Point(380, 0);
            this.points_to_click_listBox.Margin = new System.Windows.Forms.Padding(0);
            this.points_to_click_listBox.Name = "points_to_click_listBox";
            this.points_to_click_listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.points_to_click_listBox.Size = new System.Drawing.Size(100, 228);
            this.points_to_click_listBox.TabIndex = 20;
            this.points_to_click_listBox.TabStop = false;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.clear_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.clear_button.Location = new System.Drawing.Point(79, 0);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(80, 40);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "Wyczyść";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DimGray;
            this.panel_top.Controls.Add(this.minimize_button);
            this.panel_top.Controls.Add(this.button_exit);
            this.panel_top.Controls.Add(this.start_button);
            this.panel_top.Controls.Add(this.clear_button);
            this.panel_top.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(380, 40);
            this.panel_top.TabIndex = 4;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseMove);
            this.panel_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_top_MouseUp);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimize_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimize_button.ForeColor = System.Drawing.Color.Orange;
            this.minimize_button.Location = new System.Drawing.Point(300, 0);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(1);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(40, 40);
            this.minimize_button.TabIndex = 3;
            this.minimize_button.Text = "---";
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(340, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(40, 40);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(7, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 105);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sterowanie klawiszami:\r\n-- Q - zatrzymuje automatyczne klikanie\r\n-- 1 - dodaje pu" +
    "nkt do listy kliknięć\r\n-- 2 - powtarza kliknięcia od początku\r\n-- 4 - zeruje lis" +
    "te punktów do klikania\r\n";
            // 
            // timer_of_keys_actions
            // 
            this.timer_of_keys_actions.Enabled = true;
            this.timer_of_keys_actions.Interval = 200;
            this.timer_of_keys_actions.Tick += new System.EventHandler(this.timer_of_keys_actions_Tick);
            // 
            // AutoClickerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_of_keys_actions;
    }
}

