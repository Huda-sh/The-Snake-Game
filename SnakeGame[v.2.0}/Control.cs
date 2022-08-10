using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame_v._2._0_
{
    class Control
    {
        //auto-implemented properties
        public static int Lives { get; set; }
        public static bool GameOver { get; set; }
        public static int Score { get; set; }
        public static int GameSpeed { get; set; }
        public static int CurrentLevel { get; set; }

        //constrctor
        public Control() { }
        public Control(Timer gameTimer,int level)
        {
            Lives = 3;
            GameOver = false;
            Score = 0;
            GameSpeed = gameTimer.Interval;
            CurrentLevel = level;

        }

        
    }
}
