using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm03054 : Form
    {
        public frm03054()
        {
            InitializeComponent();
        }

        private void frn03054_Load(object sender, EventArgs e)
        {

        }
        static string temp = "";
        private void button1_Click(object sender, EventArgs e)
        {
            temp = "";
            int n = int.Parse(textBox1.Text);
            Towers(n, "A", "B", "C");
            label2.Text = temp;
        }
        static void Towers(int n, string from, string through, string to) 
        {
            if (n > 0)
            {
                Towers(n - 1, from, to, through);
                temp = temp + "將盤子"+n +"將柱子" + from +  "移到柱子" + to +"\n";
                Towers(n - 1, through, from, to);
            }
        }
    }
}
