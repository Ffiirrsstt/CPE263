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

        //สำหรับโปรแกรมคำนวณค่าน้ำประปาจากมิเตอร์
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
            double valueDoubleW1, valueDoubleW2;
            if (valueW1.Text != "" && valueW2.Text != "")
            {
                if (double.TryParse(valueW1.Text, out valueDoubleW1))
                {
                    if (double.TryParse(valueW2.Text, out valueDoubleW2))
                    {
                        calculate(sender, e, Math.Abs(valueDoubleW2 - valueDoubleW1));
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
                if (double.TryParse(valueW1.Text, out valueDoubleW1))
                {
                    calculate(sender, e, Math.Abs(valueDoubleW1));
                }
                else
                {
                    valueNotNum1(sender, e);
                }
            }
            else if (valueW1.Text == "")
            {
                if (double.TryParse(valueW2.Text, out valueDoubleW2))
                {
                    calculate(sender, e, Math.Abs(valueDoubleW2));
                }
                else
                {
                    valueNotNum2(sender, e);
                }
            }
        }

        //สำหรับโปรแกรมคำนวณรับค่าน้ำหนักว่าเกินมาตราฐานหรือไม่
        private void checkOutputProgram2(object sender, EventArgs e,double heightDouble,double weightDouble, int fordata)
        {
            if ((heightDouble - fordata) < weightDouble)
                outputProgram2.Text = "เกินมาตราฐาน";
            else
                outputProgram2.Text = "อยู่ในมาตราฐาน";
        }

        private void CalculationforProgram2(object sender, EventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && (female.Checked || male.Checked))
            {
                double heightDouble, weightDouble;
                if (double.TryParse(height.Text, out heightDouble))
                {
                    if (double.TryParse(weight.Text, out weightDouble))
                    {
                        if (female.Checked)
                        {
                            checkOutputProgram2(sender, e, heightDouble, weightDouble, 110);
                        }
                        else
                        {
                            checkOutputProgram2(sender, e, heightDouble, weightDouble, 100);
                        }
                    }
                    else
                        MessageBox.Show("กรุณาป้อนส่วนสูงเป็นตัวเลข");
                }
                else
                    MessageBox.Show("กรุณาป้อนส่วนสูงเป็นตัวเลข");
            }
            else
                outputProgram2.Text = "รอการกรอกข้อมูลให้ครบถ้วน";
        }


        //สำหรับโปรแกรมคำนวณค่าน้ำประปาจากมิเตอร์
        private void valueW1_change(object sender, EventArgs e)
        {
            calData(sender, e);
        }

        private void valueW2_TextChanged(object sender, EventArgs e)
        {
            calData(sender, e);
        }

        //สำหรับโปรแกรมคำนวณรับค่าน้ำหนักว่าเกินมาตราฐานหรือไม่
        private void height_TextChanged(object sender, EventArgs e)
        {
            CalculationforProgram2(sender, e);
        }

        private void weight_TextChanged(object sender, EventArgs e)
        {
            CalculationforProgram2(sender, e);
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            CalculationforProgram2(sender, e);
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            CalculationforProgram2(sender, e);
        }
    }
}
