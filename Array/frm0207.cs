using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class frm0207 : Form
    {
        public frm0207()
        {
            InitializeComponent();
        }
        int[,] A = new int[,]  {{1,2,3},{4,5,6}};
        static string Temp = "";
        private void button1_Click(object sender, EventArgs e)
        {
            matrix_traverse(ref A, A.GetUpperBound(0) + 1, A.GetUpperBound(1)+1);
            label1.Text = Temp;
        }
        static void matrix_traverse(ref int[,] A, int m, int n) 
        {
            int i, j;
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++) 
                {
                    Temp = Temp + A[i, j] + " ";
                }
                Temp = Temp + "\n";
            }
        }
    }
}
