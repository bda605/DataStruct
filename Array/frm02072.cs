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
    public partial class frm02072 : Form
    {
        int[,] A = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] B = new int[,] { { 11, 12, 13 }, { 14, 15, 16 } };
        int[,] C = new int[2, 3];
        static string Temp1 = "";
        static string Temp2 = "";
        static string Temp3 = "";
        public frm02072()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matrix_Aprint(2, 3, ref A);
            matrix_Bprint(2, 3, ref B);
            matrix_Add(2, 3, ref A, ref B, ref C);
            matrix_Cprint(2, 3, ref C);
            label1.Text = Temp1;
            label2.Text = Temp2;
            label3.Text = Temp3;
        }
        static void matrix_Aprint(int m, int n, ref int[,] A) 
        {
            int i, j;
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
        static void matrix_Bprint(int m, int n, ref int[,] B) 
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
        static void matrix_Add(int m, int n, ref int[,] A, ref int[,] B, ref int[,] C) 
        {
            int i, j;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    C[i, j] = A[i, j] + B[i, j];
        }
        static void matrix_Cprint(int m, int n, ref int[,] C) 
        {
            int i, j;
            for (i = 0; i < m; i++) {
                for (j = 0; j < n; j++) 
                {
                    if (C[i, j] >= 10)
                        Temp3 = Temp3 + C[i, j] + "  ";
                    else
                        Temp3 = Temp3 + C[i, j] + "    ";
                }
                Temp3 = Temp3 + "\n";
            }
        }
    }
    
}
