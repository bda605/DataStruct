using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm0302 : Form
    {
        public frm0302()
        {
            InitializeComponent();
        }
        static int MaxNum= 6;
        static string[] Stack = new string[MaxNum];
        static int Top = -1;
        static string Temp1;
        static string Temp2;
        static string[] A = new string[6];
        private void frm0302_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = "";
            label16.Text = "";
            Temp1 = "";
            Temp2 = "";
            int i;
            A[0] = textBox1.Text;
            A[1] = textBox2.Text;
            A[2] = textBox3.Text;
            A[3] = textBox4.Text;
            A[4] = textBox5.Text;
            A[5] = textBox6.Text;
            for(i =0;i<=5;i++)
                if (A[i] != "") 
                {
                    string item = A[i];
                    Push(item);
                }
            int t;
            for (t = 0; t <= 5; t++)
                A[t] = "";
            PrintStack();
            textBox7.Text = A[0];
            textBox8.Text = A[1];
            textBox9.Text = A[2];
            textBox10.Text = A[3];
            textBox11.Text = A[4];
            textBox12.Text = A[5];
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pop();
            int t;
            for (t = 0; t <= 5; t++)
                A[t] = "";
            PrintStack();
            textBox7.Text = A[0];
            textBox8.Text = A[1];
            textBox9.Text = A[2];
            textBox10.Text = A[3];
            textBox11.Text = A[4];
            textBox12.Text = A[5];
            textBox1.Text ="";
            textBox2.Text ="";
            textBox3.Text ="";
            textBox4.Text ="";
            textBox5.Text ="";
            textBox6.Text = "";


        }

        public static void Push(string item) 
        {
            if (Top == MaxNum - 1)
            {
                Temp2 = "堆疊是滿的";
                MessageBox.Show(Temp2);
            }
            else {
                Stack[++Top] = item;
                Temp1 = System.Convert.ToString(Top);
                MessageBox.Show("Top=" + Temp1);
            }
        }

        public static void Pop()
        {
            if (Top == -1)
            {
                Temp2 = "堆疊是空的，Pop失敗";
                MessageBox.Show(Temp2);
            }
            else {
                Temp2 = Stack[Top--] + "是從堆疊彈出資料";
                Temp1 = System.Convert.ToString(Top);
                MessageBox.Show("Top=" + Temp2);
            }
        }

        public static void PrintStack() 
        {
            int i = 0;
            if (Top == -1)
            {
                Temp2 = "堆疊為空";
            }
            else {
                for (i = Top; i >= 0; i--)
                    A[i] = Stack[i];
            }
        }
    }
}
