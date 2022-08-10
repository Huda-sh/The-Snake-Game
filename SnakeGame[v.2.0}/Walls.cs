using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame_v._2._0_
{
    
    class Walls
    {
        //auto-implemented properties
        public PictureBox Wall { get; set; }
        public int X0 { get; set; }
        public int X1 { get; set; }
        public int Y0 { get; set; }
        public int Y1 { get; set; }

        //constuctor
        public Walls()
        {
            //default constructor
        }
        public Walls(PictureBox wall)
        {
            this.Wall = new PictureBox();
            this.X0 = wall.Location.X;
            this.Y0 = wall.Location.Y;
            this.X1 = (wall.Location.X) + (wall.Size.Width);
            this.Y1 = (wall.Location.Y) + (wall.Size.Height);
        }
    }
}
