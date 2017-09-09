using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random r;
        Timer t = new Timer();
        int inc;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(inc);
            if (progressBar1.Value >= 100)
            {
                t.Stop();
                textBox1.Text = "127.0.0.1";
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            textBox1.Text = "";
            button1.Enabled = false;
            inc = r.Next(5, 15);
            float time = r.Next(1, 10);
            t.Interval = Convert.ToInt32(time * 100);
            t.Start();
        }
    }
}
