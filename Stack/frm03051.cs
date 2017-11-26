using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm03051 : Form
    {
        public frm03051()
        {
            InitializeComponent();
        }

        private void frm0305_Load(object sender, EventArgs e)
        {
            int Result, Max = 3;
            Result = face(Max);
            MessageBox.Show(Convert.ToString(Result));
        }
        static int face(int n) 
        {
            //if (n == 0) 
            //    return 1;
            //else 
            //    return n * face(n - 1);

            //if (n == 0)
            //    return 1;
            //else
            //{
            //    int a = 3 * face(n - 1);
            //    return a;
            //}
            if (n == 0)
                return 1;
            else
                return 2 * face(n - 1) + 8;
        }
    }
}
