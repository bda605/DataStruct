using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm0305 : Form
    {
        public frm0305()
        {
            InitializeComponent();
        }

        private void frm0305_Load(object sender, EventArgs e)
        {
            int Result, Max = 10;
            Result = face(Max);
            MessageBox.Show(Convert.ToString(Result));
        }
        static int face(int n) 
        {
            if (n == 0) return 1;
            else return n * face(n - 1);
        }
    }
}
