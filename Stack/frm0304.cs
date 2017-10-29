using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stack
{
    public partial class frm0304 : Form
    {
        static int MaxNum = 10;
        static char[] Stack = new char[MaxNum];
        static int TopNum = -1;

        static string Temp = "";
        public frm0304()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string str = textBox1.Text;
            for (i = 0; i <= str.Length - 1; i++)
                Stack[i] = char.Parse(str.Substring(i, 1));
            textBox2.Text = "";
            Temp = "";
            Postfix(str.Length, Stack);
            textBox2.Text = Temp;
        }
        public static void Postfix(int n, char[] Stack) 
        {
            int i = 0; TopNum = 0;
            char op;
            for (i = 0; i < n; i++) 
            {
                op = Stack[i];
                switch (op) 
                {
                    case '(':
                        if (TopNum < n) {
                            TopNum++;
                            Stack[TopNum] = op;
                        }
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        while (Priority(Stack[TopNum]) >= Priority(op)) 
                        {
                            Temp = Temp + Stack[TopNum];
                            TopNum--;
                        }
                        if (TopNum < n) 
                        {
                            TopNum++;
                            Stack[TopNum] = op;
                        }
                        break;
                    case ')':
                        while (Stack[TopNum] != '(') 
                        {
                            Temp = Temp + Stack[TopNum];
                            TopNum--;
                        }
                        TopNum--;
                        break;
                    default :
                        Temp = Temp + op;
                        break;
                }
            }
            while (TopNum > 0) 
            {
                Temp = Temp + Stack[TopNum];
                TopNum--;
            }
        }
        public static int Priority(char op) 
        {
            int p;
            switch (op)
            { 
                case '+':
                case '-':
                    p = 1;
                    break;
                case '*':
                case '/':
                    p = 2;
                    break;
                default :
                    p = 0;
                    break;

            }
            return p;
        }
    }
}
