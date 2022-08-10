using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SnakeGame_v._2._0_;

namespace SnakeGame_v._2._0_
{
    public partial class StartMenu : Form
    {

        public StartMenu()
        {
            InitializeComponent();
        }

        private void btn_Levels_Click(object sender, EventArgs e)
        {
            this.Hide();
            Levels levels = new Levels();
            levels.Show();
        }

       

        private void StartMenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_StartNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DoUWantToExit exit = new DoUWantToExit();
            DialogResult RUsure = exit.ShowDialog();
            if (RUsure == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Credits_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            DialogResult result= credits.ShowDialog();
            if (result == DialogResult.OK) ;
        }
    }
}
