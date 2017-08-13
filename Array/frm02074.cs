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
    public partial class frm02074 : Form
    {
        public frm02074()
        {
            InitializeComponent();
        }
        int[,] Sparse = new int[,] { { 5, 0, 0 }, { 0, 0, 1 }, { 3, 0, 0 }, { 0, 9, 8 } };
        int[,] Compress = new int[6, 3];
        static string Temp1 = "";
        static string Temp2 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Sparse_print(4, 3, ref Sparse);
            Compress_process(4, 3, ref Sparse, ref Compress);
            Compress_print(6, 3, ref Compress);
            label1.Text = Temp1;
            label2.Text = Temp2;
        }

        static void Sparse_print(int m, int n, ref int[,] Sparse) 
        {
            int i, j;
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++)
                    Temp1 = Temp1 + Sparse[i, j] + "  ";
                Temp1 = Temp1 + "\n";
            }
        }

        static void Compress_process(int m, int n, ref int[,] Sparse, ref int[,] Compress) 
        {
            int i, j, k;
            k = 1;
            Compress[0, 0] = m;
            Compress[0, 1] = n;
            Compress[0, 2] = 5;
            for(i = 0;i<m;i++)
                for(j = 0;j<n;j++)
                    if (Sparse[i, j] != 0) 
                    {
                        Compress[k, 0] = i;
                        Compress[k, 1] = j;
                        Compress[k, 2] = Sparse[i, j];
                        k++;
                    }
        }
        static void Compress_print(int m, int n, ref int[,] Compress) 
        {
            int i, j;
            for (i = 0; i < m; i++) 
            {
                for (j = 0; j < n; j++)
                    Temp2 = Temp2 + Compress[i, j] + "  ";
                Temp2 = Temp2 + "\n";
            }
        }

    }
}
