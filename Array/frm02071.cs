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
    public partial class frm02071 : Form
    {
        int[,] A = new int[,] {{1,2,3,4},{5,6,7,8},
        {9,10,11,12},{13,14,15,16}};
        int[,] B = new int[4, 4];
        static string Temp1 = "";
        static string Temp2 = "";
        public frm02071()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matrix_pretrans(4, 4, ref A);
            matrix_transpose(4, 4, ref A, ref B);
            matrix_posttrans(4, 4, ref B);
            label1.Text = Temp1;
            label2.Text = Temp2;
        }
        static void matrix_pretrans(int m, int n, ref int[,] A) 
        {
            int i,j;
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++) 
                {
                    if (A[i, j] >= 10)
                        Temp1 = Temp1 + A[i, j] + "  ";
                    else
                        Temp1 = Temp1 + A[i, j] + "    ";
                  
                }
                Temp1 = Temp1 + "\n";
            }
        }
        static void matrix_transpose(int m, int n, ref int[,] A,ref int[,] B) 
        {

            int i, j;
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++) 
                {
                    B[j, i] = A[i, j];
                }
            }
        }
        static void matrix_posttrans(int m, int n, ref int[,] B) 
        {
            int i, j;
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++) 
                {
                    if (B[i, j] >= 10)
                        Temp2 = Temp2 + B[i, j] + "  ";
                    else
                        Temp2 = Temp2 + B[i, j] + "    ";

                }
                Temp2 = Temp2 + "\n";
            }
        }
    }
}
