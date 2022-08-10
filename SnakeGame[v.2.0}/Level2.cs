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
    public partial class Level2 : Form
    {
        Walls[] walls = new Walls[9];
        Food food;
        Snake snake;
        public Level2()
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


            Control control = new Control(GameTImer, 2);

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
                    Level1 level1 = new Level1();
                    level1.Show();
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
                    Level3 level3 = new Level3();
                    level3.Show();
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

        private void Level2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Level2_KeyDown(object sender, KeyEventArgs e)
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
