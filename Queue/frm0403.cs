using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class frm0403 : Form
    {
        public frm0403()
        {
            InitializeComponent();
        }
        static int num = 6;
        static string[] CQueue = new string[num];
        static int Rear = 0;
        static int Front = 0;
        static string Temp1 = "";
        static string Temp2 = "";
        static string Temp3 = "";
        static string[] A = new string[num];
        private void frm0403_Load(object sender, EventArgs e)
        {
            label14.Text = Front.ToString();
            label16.Text = Rear.ToString();
            Temp1 = Front.ToString();
            Temp2 = Rear.ToString();
            label18.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            A[0] = textBox1.Text;
            A[1] = textBox2.Text;
            A[2] = textBox3.Text;
            A[3] = textBox4.Text;
            A[4] = textBox5.Text;
            A[5] = textBox6.Text;
            for (i = 0; i <= 5; i++) 
            {
                if (A[i] != "") 
                {
                    string item = A[i];
                    Enqueue(item);
                }
            }
            Show_Queue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dequeue();
            Show_Queue();
        }
        void Show_Queue() 
        {
            int t;
            for (t = 0; t <= 5; t++)
                A[t] = "";
            PrintCqueue();
            textBox7.Text = A[0];
            textBox8.Text = A[1];
            textBox9.Text = A[2];
            textBox10.Text = A[3];
            textBox11.Text = A[4];
            textBox12.Text = A[5];
            label14.Text = Temp1;
            label16.Text = Temp2;
            label18.Text = Temp3;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
        public static void Enqueue(string item) 
        {
            Rear = (Rear + 1) % num;
            if (Rear == Front)  {
                Temp3 = "環狀佇列是滿的!";
                return;
            } else {
                CQueue[Rear] = item;
                Temp2 = System.Convert.ToString(Rear);
                MessageBox.Show("Rear=" + Temp2);
            }
        }
        public static void Dequeue() 
        {
            if (Front == Rear){
                Temp3 = "環狀佇列是空的! Qeueue失敗.";
                MessageBox.Show(Temp3);
            }
            else {
                Front = (Front + 1) % num;
                Temp3 = CQueue[Front] + "是從環狀佇列刪除的資料";
                Temp1 = System.Convert.ToString(Front);
                MessageBox.Show("刪除Front=" + Temp1);
            }
        }
        public static void PrintCqueue() 
        {
            int i;
            if (Rear >= Front) {
                for (i = Rear; i >= Front + 1; i--)
                    A[i] = CQueue[i];
            }
            else {
                for (i = Rear; i != Front; i = (i + num - 1) % num)
                    A[i] = CQueue[i];
            }
        }
    }
}
