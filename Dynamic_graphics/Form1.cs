using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_graphics
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(System.Drawing.Color.Black);
        int l = 50; //длинна линии
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
            if (v!=0) g.Clear(System.Drawing.Color.White);
            angal += v;
            // v > 0 вращение по часовой
            // v < 0 вращение против часовой
            if ((angal >= 6.28) || (angal <= -6.28)) angal = 0;
            g.DrawLine(p, pictureBox1.Width / 2, pictureBox1.Height / 2, l*MathF.Cos(angal)+ pictureBox1.Width / 2, l*MathF.Sin(angal)+ pictureBox1.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Whide_trackBar_Scroll(object sender, EventArgs e)
        {
            p.Width = p.Width = Whide_trackBar.Value;
            g.Clear(System.Drawing.Color.White);
            g.DrawLine(p, pictureBox1.Width / 2, pictureBox1.Height / 2, l * MathF.Cos(angal) + pictureBox1.Width / 2, l * MathF.Sin(angal) + pictureBox1.Height / 2);

        }

        private void l_trackBar_Scroll(object sender, EventArgs e)
        {
            l = l_trackBar.Value * 10;
            g.Clear(System.Drawing.Color.White);
            g.DrawLine(p, pictureBox1.Width / 2, pictureBox1.Height / 2, l * MathF.Cos(angal) + pictureBox1.Width / 2, l * MathF.Sin(angal) + pictureBox1.Height / 2);
        }

        private void Speed_trackBar_Scroll(object sender, EventArgs e)
        {
            v = (float)Speed_trackBar.Value * 2 / 100;
        }
    }
}
