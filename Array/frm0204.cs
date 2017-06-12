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
    public partial class frm0204 : Form
    {
        int i, j, k;
        string Temp;
        int[,] Stu_Sum = new int[3, 4];
        int[,] Stu_Average = new int[3, 4];
        int[,] Subject_Sum = new int[3, 5];
        int[,] Subject_Average = new int[3, 5];
        string[] Stu_Name = { "張三", "李四", "趙武", "李六" };
        int[, ,] Score = { { { 65, 85, 78, 75, 69 }, { 66, 55, 52, 92, 47 }, { 75, 99, 63, 73, 86 }, { 77, 88, 99, 91, 99 } }, { { 77, 88, 66, 77, 66 }, { 65, 66, 88, 55, 77 }, { 70, 88, 56, 88, 88 }, { 80, 90, 95, 99, 99 } }, { { 55, 67, 56, 98, 67 }, { 66, 69, 76, 66, 78 }, { 77, 89, 88, 77, 77 }, { 88, 89, 99, 97, 88 } } };
        public frm0204()
        {
            InitializeComponent();
        }

        private void frm0204_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(k = 0;k<=2;k++)
                for(i = 0; i<=3;i++)
                    for (j = 0; j <= 4; j++)
                    {
                        Stu_Sum[k, i] = Stu_Sum[k, i] + Score[k, i, j];
                        Subject_Sum[k, j] = Subject_Sum[k, j] + Score[k, i, j];

                    }

            for (k = 0; k <= 2; k++) 
            {

                Temp = Temp + "============第" + (k + 1) + "次月考成績如下：============" + "\n";
                Temp = Temp + "姓名　　國文　 英文 　數學 　計概 　程設" + "\n";
                Temp = Temp + "===========================================" + "\n";
                for (int i = 0; i <= 3; i++) 
                {
                    Temp = Temp + Stu_Name[i];
                    for (j = 0; j <= 4; j++) 
                    {
                        Temp = Temp + "    " + Score[k, i, j];
                    }
                    Temp = Temp + "\n";
                }
                Temp = Temp + "\n";
                Temp = Temp + "\n";
                Temp = Temp + "\n";
                label1.Text = Temp;
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "學科平均";
            label4.Text = "學科平均";
            label6.Text = "學科平均";
            for (k = 0; k <= 2; k++)
                for (j = 0; j <= 4; j++)
                    Subject_Average[k, j] = Subject_Sum[k, j] / 4;

            for (j = 0; j <= 4; j++) 
            {
             label2.Text = label2.Text + "          " + Subject_Average[0,j];
             label4.Text = label4.Text + "          " + Subject_Average[1, j];
             label6.Text = label6.Text + "          " + Subject_Average[2, j];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "學生成績" + "\n" + "\n";
            label5.Text = "學生成績" + "\n" + "\n";
            label7.Text = "學生成績" + "\n" + "\n";
            for (k = 0; k <= 2; k++)
                for (i = 0; i <= 3; i++)
                    Stu_Average[k, i] = Stu_Sum[k, i] / 5;       //計算出每一位同學的平均成績
            for (i = 0; i <= 3; i++)
            {
                label3.Text = label3.Text + Stu_Average[0, i] + "\n";
                label5.Text = label5.Text + Stu_Average[1, i] + "\n";
                label7.Text = label7.Text + Stu_Average[2, i] + "\n";
            }
        }
    }
}
