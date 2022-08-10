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
    public partial class UWon : Form
    {
        public UWon()
        {
            InitializeComponent();
        }

        private void UWon_Load(object sender, EventArgs e)
        {
            label1.Text = "Congrats!... You Won!!\nYour Score is " + Control.Score;
        }
    }
}
