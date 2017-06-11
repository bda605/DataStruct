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
    public partial class frm0203 : Form
    {
        int i, j;
        string Temp = "";
        int[] Stu_Sum = new int[4];
        int[] Stu_Average = new int[4];
        int[] Subject_Sum = new int[5];
        int[] Subject_Average = new int[5];
        string[] Stu_Name= {"張三","李四","王武","熊熊"};
        int[,] Score = new int[,] { 
        { 65, 85, 78, 75, 69 }, 
        { 66, 55, 92, 47,92  },{75,99,63,73,86},{77,88,99,91,100}};


        public frm0203()
        {
            InitializeComponent();
        }

        private void frm0203_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 4; j++) 
                {
                    Stu_Sum[i] = Stu_Sum[i] + Score[i, j];
                    Subject_Sum[j] = Subject_Sum[j] + Score[i, j];
                }
            }
            Temp = "姓名　　國文　 英文 　數學 　計概 　程設" + "\n";
            Temp = Temp + "===========================================" + "\n";
            for (i = 0; i <= 3; i++) 
            {
                Temp = Temp + Stu_Name[i];
                for (j = 0; j <= 4; j++) 
                {
                    Temp = Temp + "    " + Score[i, j];
                }
                Temp = Temp + "\n";
            }
            label1.Text = Temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Total, Aver;
            Total = Score[3, 0] + Score[3, 1] + Score[3, 2] + Score[3, 3] + Score[3, 4];
            Aver = Total / 5;
            label4.Text = "總分:" + Total + "\n" + "平均=" + Aver;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "學科平均";
            for (j = 0; j <= 4; j++) 
            {
                Subject_Average[j] = Subject_Sum[j] / 4;
                label2.Text = label2.Text + "       " + Subject_Average[j];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "學生成績" + "\n" + "\n";
            for (i = 0; i <= 3; i++) 
            {
                Stu_Average[i] = Stu_Sum[i] / 5;
                label3.Text = label3.Text + Stu_Average[i] + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = "程設低於平均:" + "\n";
            for (i = 0; i <=3; i++) 
            {
                if (Score[i, 4] < Subject_Average[4])
                    label5.Text = label5.Text = Stu_Name[i] + "\n";
            }
        }
    }
}
