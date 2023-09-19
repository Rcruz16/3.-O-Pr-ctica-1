using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._O_Práctica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ftc_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textBox1.Text);
            float C = (F - 32) * 5.0f / 9.0f;
            textBox2.Text = C.ToString();

        }

        private void btn_Ctf_Click(object sender, EventArgs e)
        {
            float C = float.Parse(textBox2.Text);
            float F = (C * 9f / 5f) + 32;
            textBox1.Text = F.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "o.o";
            textBox2.Text = "o.o";
        }
    }
}
