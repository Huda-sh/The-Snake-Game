using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame_v._2._0_
{
    public partial class Level3 : Form
    {
        Walls[] walls = new Walls[17];
        Food food;
        Snake snake;
        public Level3()
        {
            InitializeComponent();
            //create the wall objects and an array of all walls
            walls[0] = new Walls(pb_TopWall);
            walls[1] = new Walls(pb_BottomWall);
            walls[2] = new Walls(pb_LeftWall);
            walls[3] = new Walls(pb_RightWall);
            walls[4] = new Walls(pictureBox1);
            walls[5] = new Walls(pictureBox2);
            walls[6] = new Walls(pictureBox3);
            walls[7] = new Walls(pictureBox4);
            walls[8] = new Walls(pictureBox5);
            walls[9] = new Walls(pictureBox6);
            walls[10] = new Walls(pictureBox7);
            walls[11] = new Walls(pictureBox8);
            walls[12] = new Walls(pictureBox9);
            walls[13] = new Walls(pictureBox10);
            walls[14] = new Walls(pictureBox11);
            walls[15] = new Walls(pictureBox12);
            walls[16] = new Walls(pictureBox13);

            Control control = new Control(GameTImer, 3);

            snake = new Snake(this);

            food = new Food(walls);

            this.Controls.Add(food.PBfood);

            GameTImer.Start();
        }

        private void GameTImer_Tick(object sender, EventArgs e)
        {
            if (Control.GameOver == true)
            {
                GameTImer.Stop();
                ULost uLost = new ULost();
                DialogResult d = uLost.ShowDialog();
                if (d == DialogResult.OK)
                {
                    this.Hide();
                    Level2 level2 = new Level2();
                    level2.Show();
                }
                else if (d == DialogResult.Cancel)
                {
                    this.Hide();
                    StartMenu startMenue = new StartMenu();
                    startMenue.Show();
                }
            }
            if (Snake.snake.Count == 20)
            {
                GameTImer.Stop();
                UWon uWon = new UWon();
                DialogResult d = uWon.ShowDialog();
                if (d == DialogResult.OK)
                {
                    this.Hide();
                    Level2 level2 = new Level2();
                    level2.Show();
                }
                else if (d == DialogResult.Cancel)
                {
                    this.Hide();
                    StartMenu startMenue = new StartMenu();
                    startMenue.Show();
                }
            }
            Snake.MoveSnake(snake, food, walls, this);
            lbl_Score.Text = ("Score: " + Control.Score);
            lbl_Lives.Text = ("Lives: " + Control.Lives);
            GameTImer.Interval = Control.GameSpeed;
        }

        private void Level3_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameTImer.Stop();
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DoUWantToExit exit = new DoUWantToExit();
                DialogResult RUsure = exit.ShowDialog();
                if (RUsure == DialogResult.Yes)
                {
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        //if (Application.OpenForms[i].Name == "StartMenue")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
                else
                    e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (GameTImer.Enabled == true)
                {
                    GameTImer.Stop();
                }
                else
                {
                    GameTImer.Start();
                }
            }
            else if ((e.KeyData == Keys.Right) && (Snake.Direction != Directions.Left))
            {
                Snake.Direction = Directions.Right;
            }
            else if ((e.KeyData == Keys.Left) && (Snake.Direction != Directions.Right))
            {
                Snake.Direction = Directions.Left;
            }
            else if ((e.KeyData == Keys.Up) && (Snake.Direction != Directions.Down))
            {
                Snake.Direction = Directions.Up;
            }
            else if ((e.KeyData == Keys.Down) && (Snake.Direction != Directions.Up))
            {
                Snake.Direction = Directions.Down;
            }
        }
    }
}
