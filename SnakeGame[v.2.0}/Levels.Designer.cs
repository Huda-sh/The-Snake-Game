
namespace SnakeGame_v._2._0_
{
    partial class Levels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ChooseLevel = new System.Windows.Forms.Label();
            this.btn_Level1 = new System.Windows.Forms.Button();
            this.btn_Level2 = new System.Windows.Forms.Button();
            this.btn_Level3 = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ChooseLevel
            // 
            this.lbl_ChooseLevel.AutoSize = true;
            this.lbl_ChooseLevel.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_ChooseLevel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ChooseLevel.Image = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.lbl_ChooseLevel.Location = new System.Drawing.Point(31, 23);
            this.lbl_ChooseLevel.Name = "lbl_ChooseLevel";
            this.lbl_ChooseLevel.Size = new System.Drawing.Size(215, 45);
            this.lbl_ChooseLevel.TabIndex = 0;
            this.lbl_ChooseLevel.Text = "Choose Level";
            // 
            // btn_Level1
            // 
            this.btn_Level1.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Level1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Level1.Location = new System.Drawing.Point(135, 162);
            this.btn_Level1.Name = "btn_Level1";
            this.btn_Level1.Size = new System.Drawing.Size(321, 68);
            this.btn_Level1.TabIndex = 2;
            this.btn_Level1.Text = "Level 1";
            this.btn_Level1.UseVisualStyleBackColor = false;
            this.btn_Level1.Click += new System.EventHandler(this.btn_Level1_Click);
            // 
            // btn_Level2
            // 
            this.btn_Level2.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Level2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Level2.Location = new System.Drawing.Point(135, 256);
            this.btn_Level2.Name = "btn_Level2";
            this.btn_Level2.Size = new System.Drawing.Size(321, 68);
            this.btn_Level2.TabIndex = 3;
            this.btn_Level2.Text = "Level 2";
            this.btn_Level2.UseVisualStyleBackColor = false;
            this.btn_Level2.Click += new System.EventHandler(this.btn_Level2_Click);
            // 
            // btn_Level3
            // 
            this.btn_Level3.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Level3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Level3.Location = new System.Drawing.Point(135, 351);
            this.btn_Level3.Name = "btn_Level3";
            this.btn_Level3.Size = new System.Drawing.Size(321, 68);
            this.btn_Level3.TabIndex = 4;
            this.btn_Level3.Text = "Level 3";
            this.btn_Level3.UseVisualStyleBackColor = false;
            this.btn_Level3.Click += new System.EventHandler(this.btn_Level3_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_GoBack.Image = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.btn_GoBack.Location = new System.Drawing.Point(42, 500);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(75, 33);
            this.btn_GoBack.TabIndex = 10;
            this.btn_GoBack.Text = "Go Back";
            this.btn_GoBack.UseVisualStyleBackColor = false;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_Level3);
            this.Controls.Add(this.btn_Level2);
            this.Controls.Add(this.btn_Level1);
            this.Controls.Add(this.lbl_ChooseLevel);
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Levels_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ChooseLevel;
        private System.Windows.Forms.Button btn_Level1;
        private System.Windows.Forms.Button btn_Level2;
        private System.Windows.Forms.Button btn_Level3;
        private System.Windows.Forms.Button btn_GoBack;
    }
}