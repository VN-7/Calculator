using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string num1, num2;
        string func;
        int ans;

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text += 1;
            num1 += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text += 2;
            num1 += 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            display.Text += btnAdd.Text;
            func = "+";
            num2 = num1;
            num1 = "";
        }

        private void btnAns_Click(object sender, EventArgs e)
        {

            if(func == "+")
            {
                int numA, numB;
                numA = Int32.Parse(num1);
                numB = Int32.Parse(num2);
                ans = numA + numB;
                num1 = "" + ans;
                display.Text ="" + ans;
            }
            if (func == "*")
            {
                int numA, numB;
                numA = Int32.Parse(num1);
                numB = Int32.Parse(num2);
                ans = numA * numB;
                num1 = "" + ans;
                display.Text = "" + ans;
            }
            if (func == "/")
            {
                int numA, numB;
                numA = Int32.Parse(num1);
                numB = Int32.Parse(num2);
                ans = numB / numA;
                num1 = "" + ans;
                display.Text = "" + ans;
            }
            if (func == "-")
            {
                int numA, numB;
                numA = Int32.Parse(num1);
                numB = Int32.Parse(num2);
                ans = numB - numA;
                num1 = "" + ans;
                display.Text = "" + ans;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text += 3;
            num1 += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text += 4;
            num1 += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text += 5;
            num1 += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text += 6;
            num1 += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text += 7;
            num1 += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text += 8;
            num1 += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text += 9;
            num1 += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text += 0;
            num1 += 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num2 = "0";
            num1 = "0";
            ans = 0;
            display.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            display.Text += btnMult.Text;
            func = "*";
            num2 = num1;
            num1 = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            display.Text += btnDiv.Text;
            func = "/";
            num2 = num1;
            num1 = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            display.Text += btnSub.Text;
            func = "-";
            num2 = num1;
            num1 = "";
        }

    }
}
