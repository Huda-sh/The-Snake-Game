
namespace SnakeGame_v._2._0_
{
    partial class Level3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level3));
            this.pb_TopWall = new System.Windows.Forms.PictureBox();
            this.GameTImer = new System.Windows.Forms.Timer(this.components);
            this.pb_RightWall = new System.Windows.Forms.PictureBox();
            this.pb_BottomWall = new System.Windows.Forms.PictureBox();
            this.pb_LeftWall = new System.Windows.Forms.PictureBox();
            this.lbl_Lives = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LeftWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_TopWall
            // 
            this.pb_TopWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_TopWall.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pb_TopWall.Location = new System.Drawing.Point(-1, 0);
            this.pb_TopWall.Name = "pb_TopWall";
            this.pb_TopWall.Size = new System.Drawing.Size(600, 25);
            this.pb_TopWall.TabIndex = 4;
            this.pb_TopWall.TabStop = false;
            // 
            // GameTImer
            // 
            this.GameTImer.Interval = 200;
            this.GameTImer.Tick += new System.EventHandler(this.GameTImer_Tick);
            // 
            // pb_RightWall
            // 
            this.pb_RightWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_RightWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_RightWall.BackgroundImage")));
            this.pb_RightWall.Location = new System.Drawing.Point(575, 25);
            this.pb_RightWall.Name = "pb_RightWall";
            this.pb_RightWall.Size = new System.Drawing.Size(25, 550);
            this.pb_RightWall.TabIndex = 7;
            this.pb_RightWall.TabStop = false;
            // 
            // pb_BottomWall
            // 
            this.pb_BottomWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_BottomWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_BottomWall.BackgroundImage")));
            this.pb_BottomWall.Location = new System.Drawing.Point(24, 575);
            this.pb_BottomWall.Name = "pb_BottomWall";
            this.pb_BottomWall.Size = new System.Drawing.Size(575, 25);
            this.pb_BottomWall.TabIndex = 6;
            this.pb_BottomWall.TabStop = false;
            // 
            // pb_LeftWall
            // 
            this.pb_LeftWall.BackColor = System.Drawing.Color.LightSlateGray;
            this.pb_LeftWall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_LeftWall.BackgroundImage")));
            this.pb_LeftWall.Location = new System.Drawing.Point(0, 25);
            this.pb_LeftWall.Name = "pb_LeftWall";
            this.pb_LeftWall.Size = new System.Drawing.Size(25, 575);
            this.pb_LeftWall.TabIndex = 5;
            this.pb_LeftWall.TabStop = false;
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lives.Location = new System.Drawing.Point(409, 2);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(60, 20);
            this.lbl_Lives.TabIndex = 9;
            this.lbl_Lives.Text = "Lifes: 3";
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
            this.lbl_Score.TabIndex = 8;
            this.lbl_Score.Text = "Score: 00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(150, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 100);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(150, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 100);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(425, 350);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 100);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(425, 150);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 100);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox6.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pictureBox6.Location = new System.Drawing.Point(175, 150);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 25);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox7.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pictureBox7.Location = new System.Drawing.Point(175, 425);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 25);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox8.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pictureBox8.Location = new System.Drawing.Point(350, 150);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 25);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox9.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pictureBox9.Location = new System.Drawing.Point(350, 425);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 25);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox10.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pictureBox10.Location = new System.Drawing.Point(175, 75);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(250, 25);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox11.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.wall;
            this.pictureBox11.Location = new System.Drawing.Point(175, 500);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(250, 25);
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.Location = new System.Drawing.Point(75, 175);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(25, 250);
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.Location = new System.Drawing.Point(500, 175);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 250);
            this.pictureBox13.TabIndex = 22;
            this.pictureBox13.TabStop = false;
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(599, 601);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Lives);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.pb_TopWall);
            this.Controls.Add(this.pb_RightWall);
            this.Controls.Add(this.pb_BottomWall);
            this.Controls.Add(this.pb_LeftWall);
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Level3_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_TopWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BottomWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_LeftWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_TopWall;
        private System.Windows.Forms.Timer GameTImer;
        private System.Windows.Forms.PictureBox pb_RightWall;
        private System.Windows.Forms.PictureBox pb_BottomWall;
        private System.Windows.Forms.PictureBox pb_LeftWall;
        private System.Windows.Forms.Label lbl_Lives;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}