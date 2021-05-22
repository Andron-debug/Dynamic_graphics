using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dynamic_graphics
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(System.Drawing.Color.Black);
        int l; //длинна линии
        //Координаты точки вращения
        int x;
        int y;
        float angal = 0;//текущий угол
        float v;// угловая скорость
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            v = (float)Speed_trackBar.Value * 2 / 1000;
            l = l_trackBar.Value * 10;
            p.Width = Whide_trackBar.Value;
            x = pictureBox1.Width / 2;
            y = pictureBox1.Height / 2;
            X_textBox.Text = x.ToString();
            Y_textBox.Text = y.ToString();
            Step_timer.Interval = 1;
            Step_timer.Start();
            Start_button.Enabled = false;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Step_timer.Start();
            Start_button.Enabled = false;
            Pause_button.Enabled = true;
        }

        private void Pause_button_Click(object sender, EventArgs e)
        {
            Step_timer.Stop();
            Start_button.Enabled = true;
            Pause_button.Enabled = false;
        }

        private void Step_timer_Tick(object sender, EventArgs e)
        {
            if (v != 0) g.Clear(System.Drawing.Color.White);
            angal += v;
            // v > 0 вращение по часовой
            // v < 0 вращение против часовой
            if ((angal >= 6.28) || (angal <= -6.28)) angal = 0;
            g.DrawLine(p, x, y, l * MathF.Cos(angal) + x, l * MathF.Sin(angal) + y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Whide_trackBar_Scroll(object sender, EventArgs e)
        {
            p.Width = p.Width = Whide_trackBar.Value;
            g.Clear(System.Drawing.Color.White);
            g.DrawLine(p, x, y, l * MathF.Cos(angal) + x, l * MathF.Sin(angal) + y);

        }

        private void l_trackBar_Scroll(object sender, EventArgs e)
        {
            l = l_trackBar.Value * 10;
            g.Clear(System.Drawing.Color.White);
            g.DrawLine(p, x, y, l * MathF.Cos(angal) + x, l * MathF.Sin(angal) + y);
        }

        private void Speed_trackBar_Scroll(object sender, EventArgs e)
        {
            v = (float)Speed_trackBar.Value * 2 / 100;
        }

        private void Color_button_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog.Color;
                g.Clear(System.Drawing.Color.White);
                g.DrawLine(p, x, y, l * MathF.Cos(angal) + x, l * MathF.Sin(angal) + y);
            }
        }

        private void X_textBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(X_textBox.Text, out x))
            {
                if ((x >= 0) && (x <= pictureBox1.Width))
                {
                    g.Clear(System.Drawing.Color.White);
                    g.DrawLine(p, x, y, l * MathF.Cos(angal) + x, l * MathF.Sin(angal) + y);
                }
                else
                {
                    Step_timer.Stop();
                    MessageBox.Show("Значения должны быть в диапазоне от 0 до " + pictureBox1.Width);
                    Step_timer.Start();
                }
            }
        }

        private void Y_textBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Y_textBox.Text, out y))
            {
                if ((y >= 0) && (y <= pictureBox1.Height))
                {
                    g.Clear(System.Drawing.Color.White);
                    g.DrawLine(p, x, y, l * MathF.Cos(angal) + x, l * MathF.Sin(angal) + y);
                }
                else
                {
                    Step_timer.Stop();
                    MessageBox.Show("Значения должны быть в диапазоне от 0 до " + pictureBox1.Height);
                    Step_timer.Start();
                }
            }
        }
    }
}
