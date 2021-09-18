using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace collecting
{
    public partial class Form2 : Form
    {
        bool goright, goleft;
        int speed_game = 23;
        int speed = 7;
        int score = 0;
        int gresala = 0;
        int nr = 0;
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
            ////this.WindowState = FormWindowState.Maximized;
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if(goleft)
            {
                goright = false;
            }
            if(goright)
            {
                goleft = false;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Right)
            {
                player.Left = player.Left + speed_game;
                goright = true;
            }
            if(e.KeyCode==Keys.Left)
            {
                player.Left = player.Left - speed_game;
                goleft = true;
            }
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            box.Top = box.Top + speed;
            if(box.Top>590)
            {
                change();
                box.Left = rnd.Next(120, 1230);
                box.Top = rnd.Next(100, 250) * -1;
            }
            if(player.Bounds.IntersectsWith(box.Bounds) && nr<4)
            {
                score = score+2;
                box.Top = 587;
               
            }
            if (player.Bounds.IntersectsWith(box.Bounds) && nr > 3)
            {
                gresala++;
                box.Top = 587;

            }
            if (gresala==3)
            {
                gameover();
            }
            label1.Text = "SCORE " + score;
            label2.Text = "GRESELI " + gresala;
        }
        
        private void change()
        {
             nr = rnd.Next(1, 5);
            switch (nr)
            {
                case 1:
                    box.Image = Properties.Resources.target4;
                        break;
                case 2:
                    box.Image = Properties.Resources.target5;
                    break;
                case 3:
                    box.Image = Properties.Resources.target3;
                    break;
                case 4:
                    box.Image = Properties.Resources.Target1;
                    break;
                case 5:
                    box.Image = Properties.Resources.target2;
                    break;
                default:
                    break;
            }

           

        }
       
        private void gameover()
        {
            timer1.Stop();
            MessageBox.Show("Ai pierdut");
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
