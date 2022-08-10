using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //this is so we can use the picturebox class
using System.Drawing;
namespace SnakeGame_v._2._0_
{
    public enum Directions
    {
        Right,Left,Up,Down,
    };
    class Snake
    {
        //Auto-implemented properties
        public static List<PictureBox> snake { get; set; }
        public static Directions Direction { get; set; }
        public static int NumberOfBodyParts { get; set; }

        //constructor
        public Snake(Form form)
        {
            snake = new List<PictureBox>();
            PictureBox Head=new PictureBox();
            Head.BackgroundImage = Image.FromFile("..\\..\\Images\\grass.png");
            Head.Image = Image.FromFile("..\\..\\Images\\black.png");
            PictureBox body1 = new PictureBox();
            PictureBox body2 = new PictureBox(); 
            body1.BackgroundImage = Image.FromFile("..\\..\\Images\\grass.png");
            body2.BackgroundImage = Image.FromFile("..\\..\\Images\\grass.png");
            body1.Image = Image.FromFile("..\\..\\Images\\red.png");
            body2.Image = Image.FromFile("..\\..\\Images\\red.png");
            snake.Add(Head);
            snake.Add(body1); snake.Add(body2);
            snake[0].Size = new Size(25, 25);
            snake[1].Size=new Size(25, 25);
            snake[2].Size=new Size(25, 25);
            snake[0].Location = new Point(400, 200);
            snake[1].Location = new Point(400, 175);
            snake[2].Location = new Point(400, 150);
            Direction = Directions.Down;
            NumberOfBodyParts = 2;
            for (int i = 0; i < Snake.snake.Count; i++)
            {
                form.Controls.Add(Snake.snake[i]);
            }
        }

        //methodes
        public static void MoveSnake(Snake TheSnake,Food food,Walls[] walls,Form form)
        {
            //moves the snake
            for (int i = snake.Count-1; i >=0; i--)
            {
                if (i==0)
                {
                    switch (Snake.Direction)
                    {
                        case Directions.Right:
                            Snake.snake[i].Location = new Point(Snake.snake[i].Location.X + 25, Snake.snake[i].Location.Y);
                            break;
                        case Directions.Left:
                            Snake.snake[i].Location = new Point(Snake.snake[i].Location.X - 25, Snake.snake[i].Location.Y);
                            break;
                        case Directions.Up:
                            Snake.snake[i].Location = new Point(Snake.snake[i].Location.X, Snake.snake[i].Location.Y - 25);
                            break;
                        case Directions.Down:
                            Snake.snake[i].Location = new Point(Snake.snake[i].Location.X, Snake.snake[i].Location.Y + 25);
                            break;
                    }
                    if (FoodCollision(food)==true)
                    {
                        Eat(food,form,walls);
                    }
                    else if (DetectCollision(walls)==true)
                    {
                        Die(TheSnake,form);
                    }
                }
                else
                {
                    //move the rest of the body
                    Snake.snake[i].Location = new Point(Snake.snake[i - 1].Location.X, Snake.snake[i - 1].Location.Y);
                }
            }
        }

        public static void Eat(Food food,Form form,Walls[] walls)
        {
            //eates the food
            switch (food.foodType)
            {
                case FoodType.Strawberry:
                    Control.Score += 1;
                    break;
                case FoodType.Apple:
                    Control.Score += 2;
                    break;
                case FoodType.Banana:
                    Control.Score += 3;
                    break;
                case FoodType.Pineapple:
                    Control.Score += 4;
                    break;
                case FoodType.Watermelon:
                    Control.Score += 5;
                    break;
            }
            Snake.AddBodyPart(form);
            if ((snake.Count-3)%5==0)
            {
                //if the snake ate 5 foods it's life will increase
                Control.Lives++;
            }
            food.GenerateFood(walls);
            if ((Control.CurrentLevel!=1)&&((snake.Count - 3) % 2 == 0))
            {
                Control.GameSpeed -= 10;
            }
        }
        public static void AddBodyPart(Form form)
        {
            NumberOfBodyParts++;
            PictureBox body = new PictureBox();
            snake.Add(body);
            snake[NumberOfBodyParts].BackgroundImage = Image.FromFile("..\\..\\Images\\grass.png");
            snake[NumberOfBodyParts].Image = Image.FromFile("..\\..\\Images\\red.png");
            snake[NumberOfBodyParts].Size = new Size(25, 25);
            form.Controls.Add(snake[NumberOfBodyParts]);
        }
        public static void Die(Snake TheSnake,Form form)
        {
            Control.Lives--;
            if (Control.Lives==0)
            {
                Control.GameOver = true;
            }
            else
            {
                Control.GameSpeed = 200;
                for (int i = 0; i < snake.Count; i++)
                {
                    form.Controls.Remove(snake[i]);
                }
                TheSnake = new Snake(form);
            }
        }
        public static bool DetectCollision(Walls[] walls)
        {
            for (int i = 0; i < walls.Length; i++)
            {
                //goes into a loop of all walls
                if (((snake[0].Location.X >= walls[i].X0) && (snake[0].Location.X <= walls[i].X1 - 25)) &&
                    ((snake[0].Location.Y >= walls[i].Y0) && (snake[0].Location.Y <= walls[i].Y1 - 25)))
                {
                    return true;
                }
            }
            for (int i = 3; i < snake.Count-1; i++)
            {
                //detects the collision with the body
                if ((Snake.snake[0].Location.X == Snake.snake[i].Location.X) &&
                    (Snake.snake[0].Location.Y == Snake.snake[i].Location.Y))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool FoodCollision(Food food)
        {
            //detect the collision with the food
            if ((snake[0].Location.X == food.PBfood.Location.X) &&
                (snake[0].Location.Y == food.PBfood.Location.Y))
            {
                return true;
            }
            return false;
        }

        
    }
}
