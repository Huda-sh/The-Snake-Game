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
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenue = new StartMenu();
            startMenue.Show();
        }

        private void btn_Level1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 level1 = new Level1();
            level1.Show();
        }

        private void btn_Level2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level2 level2 = new Level2();
            level2.Show();
        }

        private void btn_Level3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level3 level3 = new Level3();
            level3.Show();
        }

        private void Levels_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DoUWantToExit exit = new DoUWantToExit();
                DialogResult RUsure = exit.ShowDialog();
                if (RUsure == DialogResult.Yes)
                {
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i].Name == "StartMenue")
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
    }
}
