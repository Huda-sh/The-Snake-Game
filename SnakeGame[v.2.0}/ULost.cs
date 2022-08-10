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
    public partial class ULost : Form
    {
        public ULost()
        {
            InitializeComponent();
        }

        private void ULost_Load(object sender, EventArgs e)
        {
            label1.Text = "GAME OVER!!!\nYou Lost...";
        }
    }
}
