
namespace SnakeGame_v._2._0_
{
    partial class Level1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.GameTImer = new System.Windows.Forms.Timer(this.components);
            this.pb_TopWall = new System.Windows.Forms.PictureBox();
            this.pb_LeftWall = new System.Windows.Forms.PictureBox();
            this.pb_BottomWall = new System.Windows.Forms.PictureBox();
            this.pb_RightWall = new System.Windows.Forms.PictureBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Lives = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RightWall)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTImer
            // 
            this.GameTImer.Interval = 200;
            this.GameTImer.Tick += new System.EventHandler(this.GameTImer_Tick);
            // 
            // pb_TopWall
            // 
            this.pb_TopWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_TopWall.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pb_TopWall.Location = new System.Drawing.Point(0, 0);
            this.pb_TopWall.Name = "pb_TopWall";
            this.pb_TopWall.Size = new System.Drawing.Size(600, 25);
            this.pb_TopWall.TabIndex = 0;
            this.pb_TopWall.TabStop = false;
            // 
            // pb_LeftWall
            // 
            this.pb_LeftWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_LeftWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_LeftWall.BackgroundImage")));
            this.pb_LeftWall.Location = new System.Drawing.Point(0, 25);
            this.pb_LeftWall.Name = "pb_LeftWall";
            this.pb_LeftWall.Size = new System.Drawing.Size(25, 575);
            this.pb_LeftWall.TabIndex = 1;
            this.pb_LeftWall.TabStop = false;
            // 
            // pb_BottomWall
            // 
            this.pb_BottomWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_BottomWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_BottomWall.BackgroundImage")));
            this.pb_BottomWall.Location = new System.Drawing.Point(25, 575);
            this.pb_BottomWall.Name = "pb_BottomWall";
            this.pb_BottomWall.Size = new System.Drawing.Size(575, 25);
            this.pb_BottomWall.TabIndex = 2;
            this.pb_BottomWall.TabStop = false;
            // 
            // pb_RightWall
            // 
            this.pb_RightWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_RightWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_RightWall.BackgroundImage")));
            this.pb_RightWall.Location = new System.Drawing.Point(575, 25);
            this.pb_RightWall.Name = "pb_RightWall";
            this.pb_RightWall.Size = new System.Drawing.Size(25, 550);
            this.pb_RightWall.TabIndex = 3;
            this.pb_RightWall.TabStop = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.ForeColor = System.Drawing.Color.Black;
            this.lbl_Score.Location = new System.Drawing.Point(55, 3);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(77, 20);
            this.lbl_Score.TabIndex = 4;
            this.lbl_Score.Text = "Score: 00";
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lives.Location = new System.Drawing.Point(409, 2);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(60, 20);
            this.lbl_Lives.TabIndex = 5;
            this.lbl_Lives.Text = "Lifes: 3";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(599, 601);
            this.Controls.Add(this.lbl_Lives);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.pb_RightWall);
            this.Controls.Add(this.pb_BottomWall);
            this.Controls.Add(this.pb_LeftWall);
            this.Controls.Add(this.pb_TopWall);
            this.DoubleBuffered = true;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level1_FormClosing_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RightWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTImer;
        private System.Windows.Forms.PictureBox pb_TopWall;
        private System.Windows.Forms.PictureBox pb_LeftWall;
        private System.Windows.Forms.PictureBox pb_BottomWall;
        private System.Windows.Forms.PictureBox pb_RightWall;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label lbl_Lives;
    }
}