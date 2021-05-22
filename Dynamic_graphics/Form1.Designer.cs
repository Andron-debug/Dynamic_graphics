
namespace Dynamic_graphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Start_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Step_timer = new System.Windows.Forms.Timer(this.components);
            this.Speed_trackBar = new System.Windows.Forms.TrackBar();
            this.Whide_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_trackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Color_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whide_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(630, 43);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(94, 29);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "Пуск";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Pause_button
            // 
            this.Pause_button.Location = new System.Drawing.Point(630, 82);
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.Size = new System.Drawing.Size(94, 29);
            this.Pause_button.TabIndex = 1;
            this.Pause_button.Text = "Пауза";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.Pause_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(46, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 381);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Step_timer
            // 
            this.Step_timer.Tick += new System.EventHandler(this.Step_timer_Tick);
            // 
            // Speed_trackBar
            // 
            this.Speed_trackBar.Location = new System.Drawing.Point(609, 174);
            this.Speed_trackBar.Minimum = -10;
            this.Speed_trackBar.Name = "Speed_trackBar";
            this.Speed_trackBar.Size = new System.Drawing.Size(179, 56);
            this.Speed_trackBar.SmallChange = 2;
            this.Speed_trackBar.TabIndex = 5;
            this.Speed_trackBar.Value = 10;
            this.Speed_trackBar.Scroll += new System.EventHandler(this.Speed_trackBar_Scroll);
            // 
            // Whide_trackBar
            // 
            this.Whide_trackBar.Location = new System.Drawing.Point(609, 233);
            this.Whide_trackBar.Minimum = 1;
            this.Whide_trackBar.Name = "Whide_trackBar";
            this.Whide_trackBar.Size = new System.Drawing.Size(179, 56);
            this.Whide_trackBar.TabIndex = 4;
            this.Whide_trackBar.Value = 5;
            this.Whide_trackBar.Scroll += new System.EventHandler(this.Whide_trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Толшина";
            // 
            // l_trackBar
            // 
            this.l_trackBar.Location = new System.Drawing.Point(609, 295);
            this.l_trackBar.Maximum = 15;
            this.l_trackBar.Minimum = 1;
            this.l_trackBar.Name = "l_trackBar";
            this.l_trackBar.Size = new System.Drawing.Size(179, 56);
            this.l_trackBar.TabIndex = 7;
            this.l_trackBar.Value = 8;
            this.l_trackBar.Scroll += new System.EventHandler(this.l_trackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Длинна";
            // 
            // Color_button
            // 
            this.Color_button.Location = new System.Drawing.Point(630, 336);
            this.Color_button.Name = "Color_button";
            this.Color_button.Size = new System.Drawing.Size(134, 33);
            this.Color_button.TabIndex = 9;
            this.Color_button.Text = "Выбрать цвет";
            this.Color_button.UseVisualStyleBackColor = true;
            this.Color_button.Click += new System.EventHandler(this.Color_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // X_textBox
            // 
            this.X_textBox.Location = new System.Drawing.Point(614, 379);
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(58, 27);
            this.X_textBox.TabIndex = 13;
            this.X_textBox.TextChanged += new System.EventHandler(this.X_textBox_TextChanged);
            // 
            // Y_textBox
            // 
            this.Y_textBox.Location = new System.Drawing.Point(614, 412);
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(58, 27);
            this.Y_textBox.TabIndex = 14;
            this.Y_textBox.TextChanged += new System.EventHandler(this.Y_textBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Y_textBox);
            this.Controls.Add(this.X_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Color_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_trackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Whide_trackBar);
            this.Controls.Add(this.Speed_trackBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.Start_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whide_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Step_timer;
        private System.Windows.Forms.TrackBar Speed_trackBar;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TrackBar Whide_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar l_trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button Color_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X_textBox;
        private System.Windows.Forms.TextBox Y_textBox;
    }
}

