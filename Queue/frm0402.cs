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
    public partial class frm0402 : Form
    {
        public frm0402()
        {
            InitializeComponent();
        }
        static int MaxNum = 6;
        static string[] Queue = new string[MaxNum];
        static int Reader = -1;
        static int Front = -1;
        static string Temp1 = "";
        static string Temp2 = "";
        static string Temp3 = "";
        static string Temp4 = "";
        static string[] A = new string[MaxNum];
        static TextBox[] TB1 = new TextBox[MaxNum];
        int i;

        private void frm0402_Load(object sender, EventArgs e)
        {
            Label14.Text = Front.ToString();
            Label16.Text = Reader.ToString();
            Temp1 = Front.ToString();
            Temp2 = Reader.ToString();
            Label18.Text = "";
            int shiftx, shifty, gapx, gapy;
            shiftx = 40;
            shifty = 28;
            gapx = 30;
            gapy = 20;
            for (i = 0; i <= MaxNum - 1; i++) 
            {
                TB1[i] = new TextBox();
                TB1[i].Height = 22;
                TB1[i].Width = 60;
                TB1[i].Left = shiftx;
                TB1[i].Top = shifty + gapy * i;
                GroupBox1.Controls.Add(TB1[i]);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i;
            string item;
            for (i = 0; i <= MaxNum - 1; i++)
                A[i] = TB1[i].Text;
            for (i = 0; i <= MaxNum - 1; i++) 
            {
                if (!string.IsNullOrEmpty(A[i])) 
                {
                    item = A[i];
                    Enqueue(item);
                }
            }
            Show_Queue();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dequeue();
            Show_Queue();
        }
        void Show_Queue() 
        {
            int t;
            for (t = 0; t <= MaxNum-1; t++)
                A[t] = "";
            PrintQueue();
            TextBox7.Text = A[0];
            TextBox8.Text = A[1];
            TextBox9.Text = A[2];
            TextBox10.Text = A[3];
            TextBox11.Text = A[4];
            TextBox12.Text = A[5];
            Label14.Text = Temp1;
            Label16.Text = Temp2;
            Label18.Text = Temp3;
            Label19.Text = Temp4;

        }
        public static void Enqueue(string item) 
        {
            if (Reader == MaxNum - 1)
            {
                Temp3 = "佇列是滿的!";
                MessageBox.Show(Temp3);
            }
            else {
                Queue[++Reader] = item;
                Temp2 = System.Convert.ToString(Reader);
                MessageBox.Show("Reader=" + Temp2);
            }
        }
        public static void Dequeue() 
        {
            if (Front == Reader)
            {
                Temp3 = "佇列是空的! Dequeue失敗";
                MessageBox.Show(Temp3);
            }
            else {
                Temp3 = Queue[++Front];
                Temp1 = System.Convert.ToString(Front);
                MessageBox.Show("刪除Front=" + Temp1);
            }
        }
        public static void PrintQueue() 
        {
            int i;
            for (i = Reader; i >= Front + 1; i--)
                A[i] = Queue[i];
        }
    }
}
