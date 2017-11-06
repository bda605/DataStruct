using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm03053 : Form
    {
        public frm03053()
        {
            InitializeComponent();
        }

        private void frm03053_Load(object sender, EventArgs e)
        {
            int a = 18, b = 15;
            MessageBox.Show("最大公因數:"+GCD(a,b));
        }
        static int GCD(int a, int b) 
        {
            int c;
            c = a % b;
            if (c == 0)
                return b;
            else
                return GCD(b, c);
        }
    }
}
