using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SnakeGame_v._2._0_
{
    public enum FoodType
    {
        Banana, Apple, Strawberry, Watermelon, Pineapple,
    };
    class Food
    {
        //Auto-implemented properties
        public PictureBox PBfood { get; set; }
        public FoodType foodType { get; set; }

        //constructor
        public Food(Walls[] walls)
        {
            Random rndType = new Random();
            foodType = (FoodType)(rndType.Next(0, 4));
            PBfood = new PictureBox();
            PBfood.Size = new Size(25, 25);
            PBfood.BackgroundImage = Image.FromFile("..\\..\\Images\\grass.png");
            SetFoodImage(foodType);
            //set the location of the food
            SetSuitableFoodLocation(walls);
            
            
        }
        public void GenerateFood(Walls[] walls)
        {
            Random rndType = new Random();
            FoodType newfood;
            do
            {
                newfood = (FoodType)(rndType.Next(0, 4));
            } while (newfood==this.foodType);
            this.foodType = newfood;
            SetFoodImage(this.foodType);
            SetSuitableFoodLocation(walls);
            
            
        }
        public void SetSuitableFoodLocation(Walls[] walls)
        {
            bool sameLocSnake = true;
            bool sameLocWall = true;
            while (sameLocSnake == true || sameLocWall == true) //this so the food won't be on the sae location of the snake bod
            {
                sameLocSnake = false;
                sameLocWall = false;
                Random rnd = new Random();
                PBfood.Location = new Point(rnd.Next(1, 22) * 25, rnd.Next(1, 22) * 25);
                for (int i = 0; i < Snake.snake.Count; i++)
                {
                    if (Snake.snake[i].Location == PBfood.Location)
                    {
                        sameLocSnake = true;
                        break;
                    }
                }
                for (int i = 0; i < walls.Length; i++)
                {
                    //goes into a loop of all walls
                    if (((PBfood.Location.X >= walls[i].X0) && (PBfood.Location.X <= walls[i].X1 - 25)) &&
                        ((PBfood.Location.Y >= walls[i].Y0) && (PBfood.Location.Y <= walls[i].Y1 - 25)))
                    {
                        sameLocWall = true;
                        break;
                    }
                }
            }
        }
        public void SetFoodImage(FoodType type)
        {
            switch (type)
            {
                case FoodType.Banana:
                    PBfood.Image = Image.FromFile("..\\..\\Images\\banana.png");
                    break;
                case FoodType.Apple:
                    PBfood.Image = Image.FromFile("..\\..\\Images\\apple.png");
                    break;
                case FoodType.Strawberry:
                    PBfood.Image = Image.FromFile("..\\..\\Images\\strawberry.png");
                    break;
                case FoodType.Watermelon:
                    PBfood.Image = Image.FromFile("..\\..\\Images\\watermelon.png");
                    break;
                case FoodType.Pineapple:
                    PBfood.Image = Image.FromFile("..\\..\\Images\\pineapple.png");
                    break;
            }
        }
    }
}
