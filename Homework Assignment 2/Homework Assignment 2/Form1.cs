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
            /*check.Text = "X: " + player.Location.X + ", Y: " + player.Location.Y
            +"\r\nX: " + pictureBox2.Location.X + ", Y: " + pictureBox2.Location.Y
            + "\r\nX: " + pictureBox3.Location.X + ", Y: " + pictureBox3.Location.Y
            + "\r\nX: " + pictureBox4.Location.X + ", Y: " + pictureBox4.Location.Y
            + "\r\nX: " + pictureBox5.Location.X + ", Y: " + pictureBox5.Location.Y
            + "\r\nX: " + pictureBox6.Location.X + ", Y: " + pictureBox6.Location.Y
            + "\r\nX: " + pictureBox7.Location.X + ", Y: " + pictureBox7.Location.Y
            + "\r\nX: " + pictureBox8.Location.X + ", Y: " + pictureBox8.Location.Y
            + "\r\nX: " + pictureBox9.Location.X + ", Y: " + pictureBox9.Location.Y
            + "\r\nX: " + pictureBox10.Location.X + ", Y: " + pictureBox10.Location.Y;*/
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

        private void calculateplayerPoints(object sender, EventArgs e)
        {
            playerPoints += dice;
            if (playerPoints > 100)
                playerPoints = 100 - (playerPoints % 100);
        }

        private void walk(object sender, EventArgs e)
        {
            calculateplayerPoints(sender, e);
            calculateXPosition(sender, e);
            calculateYPosition(sender, e);
            player.Location = new Point(positionX, positionY);
            check.Text = "position : "+playerPoints +"\r\ndice : "+dice+ "\r\nX: " + player.Location.X + ", Y: " + player.Location.Y;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            StopDice = !StopDice;
            check.Text = StopDice.ToString();
            if (StopDice)
            {
                walk(sender, e);
                MessageBox.Show("hi");
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
