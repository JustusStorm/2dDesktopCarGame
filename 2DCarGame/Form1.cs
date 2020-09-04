using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DCarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOver.Visible = false;
        }

        private void PlayerCar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }







        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLine(gameSpeed);
            MoveEnemy(gameSpeed);
            MoveCoin(gameSpeed);
            CollectedCoins(gameSpeed);
            GameOverMessage();
        }

        
        void GameOverMessage()
        {
            if (PlayerCar.Bounds.IntersectsWith(BigBox.Bounds) ||
                PlayerCar.Bounds.IntersectsWith(SmallBox.Bounds) ||
                PlayerCar.Bounds.IntersectsWith(Barrel.Bounds))
            {
                timer1.Enabled = false;
                GameOver.Visible = true;
            }
        }


        void MoveEnemy(int speed)
        {

            var rand = new Random();

            if (SmallBox.Top >= 500)
            { SmallBox.Top = 0; SmallBox.Left = rand.Next(5, 450); }
            else { SmallBox.Top += speed; }

            if (BigBox.Top >= 500)
            { BigBox.Top = 0; BigBox.Left = rand.Next(5, 425); }
            else { BigBox.Top += speed; }

            if (Barrel.Top >= 500)
            { Barrel.Top = 0; Barrel.Left = rand.Next(5, 450); }
            else { Barrel.Top += speed; }

        }


        void MoveCoin(int speed)
        {
            var rand = new Random();

            if (Coin1.Top >= 500)
            { Coin1.Top = 0; Coin1.Left = rand.Next(5, 460); }
            else { Coin1.Top += speed; }

            if (Coin2.Top >= 500)
            { Coin2.Top = 0; Coin2.Left = rand.Next(5, 460); }
            else { Coin2.Top += speed; }

            if (Coin3.Top >= 500)
            { Coin3.Top = 0; Coin3.Left = rand.Next(5, 460); }
            else { Coin3.Top += speed; }

            if (Coin4.Top >= 500)
            { Coin4.Top = 0; Coin4.Left = rand.Next(5, 460); }
            else { Coin4.Top += speed; }

        }

        int coins = 0;
        void CollectedCoins(int speed)
        {
            var rand = new Random();

            if (PlayerCar.Bounds.IntersectsWith(Coin1.Bounds))
            {
                
                Coin1.Top = 0; Coin1.Left = rand.Next(5, 460); 
                coins++;
                CoinLabel.Text = $"Coins = {coins}";
            }
            if (PlayerCar.Bounds.IntersectsWith(Coin2.Bounds))
            {
                
                Coin2.Top = 0; Coin2.Left = rand.Next(5, 460);
                coins++;
                CoinLabel.Text = $"Coins = {coins}";
            }
            if (PlayerCar.Bounds.IntersectsWith(Coin3.Bounds))
            {
                Coin3.Top = 0; Coin3.Left = rand.Next(5, 460);
                coins++;
                CoinLabel.Text = $"Coins = {coins}";
            }
            if (PlayerCar.Bounds.IntersectsWith(Coin4.Bounds))
            {
                Coin4.Top = 0; Coin4.Left = rand.Next(5, 460);
                coins++;
                CoinLabel.Text = $"Coins = {coins}";
            }



               
                 
                
        }

        
        void MoveLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox7.Top >= 500)
            { pictureBox7.Top = 0; }
            else { pictureBox7.Top += speed; }

            if (pictureBox8.Top >= 500)
            { pictureBox8.Top = 0; }
            else { pictureBox8.Top += speed; }

            if (pictureBox9.Top >= 500)
            { pictureBox9.Top = 0; }
            else { pictureBox9.Top += speed; }

            if (pictureBox10.Top >= 500)
            { pictureBox10.Top = 0; }
            else { pictureBox10.Top += speed; }

        }

        int gameSpeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Left)
            {
                if (PlayerCar.Left > 0)
                {
                    PlayerCar.Left -= 14;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (PlayerCar.Right < (500 - 24)) // -24 is the pixel wdith from the middle of the car to farest right edge of car
                {
                    PlayerCar.Left += 14;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gameSpeed < 21)
                {
                    gameSpeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gameSpeed > 0)
                {
                    gameSpeed--;
                }
            }
        }
    }
}
