using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e, double fordata)
        {
            double result=0;
            diff.Text = fordata.ToString();
            if (fordata <= 10)
                result = fordata * 5;
            else
            {
                result = 50;
                if(fordata <= 50)
                    result += (fordata-10) * 6;
                else
                {
                    result += 240+((fordata-50)*7);
                }
            }
            outputCal.Text = result.ToString();
        }

        private void valueNotNum1(object sender, EventArgs e)
        {
            MessageBox.Show("กรุณาป้อนค่าจากมิเตอร์ครั้งก่อนหน้าเป็นตัวเลข");
            valueW1.Clear();
            valueW1.Focus();
        }

        private void valueNotNum2(object sender, EventArgs e )
        {
            MessageBox.Show("กรุณาป้อนค่าจากมิเตอร์ครั้งล่าสุดเป็นตัวเลข");
            valueW2.Clear();
            valueW2.Focus();
        }

        private void calData(object sender, EventArgs e)
        {
            double valueIntW1, valueIntW2;
            if (valueW1.Text != "" && valueW2.Text != "")
            {
                if (double.TryParse(valueW1.Text, out valueIntW1))
                {
                    if (double.TryParse(valueW2.Text, out valueIntW2))
                    {
                        calculate(sender, e, Math.Abs(valueIntW2 - valueIntW1));
                    }
                    else
                    {
                        valueNotNum2(sender, e);
                    }
                }
                else
                {
                    valueNotNum1(sender, e);
                }
            }
            else if (valueW2.Text == "")
            {
                if (double.TryParse(valueW1.Text, out valueIntW1))
                {
                    calculate(sender, e, Math.Abs(valueIntW1));
                }
                else
                {
                    valueNotNum1(sender, e);
                }
            }
            else if (valueW1.Text == "")
            {
                if (double.TryParse(valueW2.Text, out valueIntW2))
                {
                    calculate(sender, e, Math.Abs(valueIntW2));
                }
                else
                {
                    valueNotNum2(sender, e);
                }
            }
        }

        private void valueW1_change(object sender, EventArgs e)
        {
            calData(sender, e);
        }

        private void valueW2_TextChanged(object sender, EventArgs e)
        {
            calData(sender, e);
        }
    }
}
