using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm03052 : Form
    {
        public frm03052()
        {
            InitializeComponent();
        }

        private void frm03052_Load(object sender, EventArgs e)
        {
            int Max = 9;
            int Sum = Total(9);
            MessageBox.Show(Sum.ToString());
        }
        static int Total(int N) 
        {
            if (N <= 2)
                return 1;
            else
                return Total(N - 2) + Total(N - 1);
        }
    }
}
