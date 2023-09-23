using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Assignment_2
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int dice,positionX, positionY, playerPoints = 1;
        Boolean StopDice=true;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateYPosition(object sender, EventArgs e)
        {
            if (playerPoints >= 1 && playerPoints <= 10)
                positionY = 573;
            else if (playerPoints >= 11 && playerPoints <= 20)
                positionY = 511;
            else if (playerPoints >= 21 && playerPoints <= 30)
                positionY = 449;
            else if (playerPoints >= 31 && playerPoints <= 40)
                positionY = 386;
            else if (playerPoints >= 41 && playerPoints <= 50)
                positionY = 323;
            else if (playerPoints >= 51 && playerPoints <= 60)
                positionY = 260;
            else if (playerPoints >= 61 && playerPoints <= 70)
                positionY = 196;
            else if (playerPoints >= 71 && playerPoints <= 80)
                positionY = 134;
            else if (playerPoints >= 81 && playerPoints <= 90)
                positionY = 73;
            else
                positionY = 10;
        }

        private void calculateXPosition(object sender, EventArgs e)
        {
            if ((playerPoints >= 1 && playerPoints <= 10) || (playerPoints >= 21 && playerPoints <= 30) ||
                (playerPoints >= 41 && playerPoints <= 50) || (playerPoints >= 61 && playerPoints <= 70) ||
                (playerPoints >= 81 && playerPoints <= 90))
                if (playerPoints % 10 == 0)
                    positionX = 795;
                else
                    positionX = 20 + (86 * ((playerPoints % 10) - 1));
            else
                if (playerPoints % 10 == 0)
                positionX = 20;
            else
                positionX = 20 + (86 * (10 - (playerPoints % 10)));
        }

        private async void slider(object sender, EventArgs e)
        {
            int[,] numberSlider = { { 2, 23 }, { 6, 45 }, { 20, 59 }, { 52, 72 }, { 57, 96 }, { 71, 92 }                //ขึ้นบันได
                                    ,{ 43, 17 }, { 50, 5 }, {56 ,8  }, { 73, 15}, { 84,58 }, { 87,49 }, {98 ,40 }};     //ลงสไลด์เดอร์งู
            for (int i = 0; i < numberSlider.GetLength(0); i++)
            {
                if (playerPoints == numberSlider[i, 0])
                {
                    await Task.Delay(300);
                    playerPoints = numberSlider[i, 1];
                    walking(sender, e);
                    break;
                }
            }
        }

        private void calculateplayerPoints(object sender, EventArgs e)
        {
            playerPoints += dice;
            if (playerPoints > 100)
                playerPoints = 100 - (playerPoints % 100);
        }

        private void walking(object sender, EventArgs e)
        {
            calculateXPosition(sender, e);
            calculateYPosition(sender, e);
            player.Location = new Point(positionX, positionY);
        }

        private void walkRUN(object sender, EventArgs e)
        {
            calculateplayerPoints(sender, e);
            walking(sender, e);
            slider(sender, e);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            StopDice = !StopDice;
            if (StopDice)
            {
                btnRoll.Enabled = false;
                walkRUN(sender, e);
                txtOutput.Text = "ผลลัพธ์ของลูกเต๋า";
                btnRoll.Text = "คลิกเพื่อทอยลูกเต๋า";
                btnRoll.Enabled = true;
            }
            else
            {
                btnRoll.Text = "คลิกเพื่อหยุดลูกเต๋า";
                txtOutput.Text = "กำลังทำการสุ่มลูกเต๋า";
            }    
            while (!StopDice)
            {
                dice = random.Next(1, 7); 
                string imagePath = Path.Combine(Application.StartupPath, "dice"+dice+".jpg");
                imgOutput.Image = Image.FromFile(imagePath);
                await Task.Delay(100);
            }
        }
    }
}
