using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forNo5(object sender, EventArgs e)
        {
            int result,count;
            List<List<int>> resultNum = new List<List<int>>();
            for (int Num1 = 0; Num1 <= 45; Num1++)
            {
                for (int Num2 = 45; Num2 >= 0; Num2--)
                {
                    result = Num1 + Num2;
                    if (result == 45)
                    {
                        if (txtOutputNo5.Text == "")
                            txtOutputNo5.Text = "\t( " + Num1.ToString() + " + " + Num2.ToString() + " ) = " + result.ToString();
                        else
                            txtOutputNo5.Text += "\r\n\t( " + Num1.ToString() + " + " + Num2.ToString() + " ) = " + result.ToString();
                        resultNum.Add(new List<int> { Num1, Num2 });
                    }
                }
            }
        }

        private void calMax_Click(object sender, EventArgs e)
        {
            
            float sum = 0,max, average;
            if (int.TryParse(valueMax.Text, out int result))
            { 
                max = result;
                for (int roundNum =1; roundNum<=max; roundNum++)
                    sum += roundNum;
                average = sum / max;
                txtOutputNo4.Text = "ผลบวก\t:\t" + sum.ToString() + "\r\nค่าเฉลี่ย\t:\t" + average.ToString();
            }
            else
            {
                txtOutputNo4.Text = "โปรดป้อนตัวเลข";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            forNo5(sender, e);
        }
    }
}
