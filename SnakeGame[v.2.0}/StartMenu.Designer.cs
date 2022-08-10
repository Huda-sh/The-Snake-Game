
namespace SnakeGame_v._2._0_
{
    partial class StartMenu
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_StartNewGame = new System.Windows.Forms.Button();
            this.btn_Levels = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbl_title.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Green;
            this.lbl_title.Location = new System.Drawing.Point(147, 46);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(294, 38);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "The Snake Game";
            // 
            // btn_StartNewGame
            // 
            this.btn_StartNewGame.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_StartNewGame.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartNewGame.ForeColor = System.Drawing.Color.Olive;
            this.btn_StartNewGame.Location = new System.Drawing.Point(53, 172);
            this.btn_StartNewGame.Name = "btn_StartNewGame";
            this.btn_StartNewGame.Size = new System.Drawing.Size(208, 55);
            this.btn_StartNewGame.TabIndex = 1;
            this.btn_StartNewGame.Text = "Start New Game";
            this.btn_StartNewGame.UseVisualStyleBackColor = false;
            this.btn_StartNewGame.Click += new System.EventHandler(this.btn_StartNewGame_Click);
            // 
            // btn_Levels
            // 
            this.btn_Levels.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Levels.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Levels.ForeColor = System.Drawing.Color.Olive;
            this.btn_Levels.Location = new System.Drawing.Point(53, 261);
            this.btn_Levels.Name = "btn_Levels";
            this.btn_Levels.Size = new System.Drawing.Size(208, 55);
            this.btn_Levels.TabIndex = 3;
            this.btn_Levels.Text = "Levels";
            this.btn_Levels.UseVisualStyleBackColor = false;
            this.btn_Levels.Click += new System.EventHandler(this.btn_Levels_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.Olive;
            this.btn_Exit.Location = new System.Drawing.Point(53, 434);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(208, 55);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Credits
            // 
            this.btn_Credits.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Credits.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Credits.ForeColor = System.Drawing.Color.Olive;
            this.btn_Credits.Location = new System.Drawing.Point(53, 352);
            this.btn_Credits.Name = "btn_Credits";
            this.btn_Credits.Size = new System.Drawing.Size(208, 55);
            this.btn_Credits.TabIndex = 6;
            this.btn_Credits.Text = "Credits";
            this.btn_Credits.UseVisualStyleBackColor = false;
            this.btn_Credits.Click += new System.EventHandler(this.btn_Credits_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wp2409705;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_Credits);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Levels);
            this.Controls.Add(this.btn_StartNewGame);
            this.Controls.Add(this.lbl_title);
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartMenue_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Levels;
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Button btn_StartNewGame;
        private System.Windows.Forms.Button btn_Credits;
    }
}

