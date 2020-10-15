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
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(12, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // cursor_coordinates_timer
            // 
            this.cursor_coordinates_timer.Interval = 10;
            this.cursor_coordinates_timer.Tick += new System.EventHandler(this.cursor_coordinates_timer_Tick);
            // 
            // cursor_coordinates_label
            // 
            this.cursor_coordinates_label.AutoSize = true;
            this.cursor_coordinates_label.Location = new System.Drawing.Point(12, 38);
            this.cursor_coordinates_label.Name = "cursor_coordinates_label";
            this.cursor_coordinates_label.Size = new System.Drawing.Size(174, 19);
            this.cursor_coordinates_label.TabIndex = 1;
            this.cursor_coordinates_label.Text = "Współrzędne kursora: 0 , 0";
            // 
            // AutoClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cursor_coordinates_label);
            this.Controls.Add(this.start_button);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AutoClickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer cursor_coordinates_timer;
        private System.Windows.Forms.Label cursor_coordinates_label;
    }
}

