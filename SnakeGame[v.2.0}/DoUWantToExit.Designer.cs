
namespace SnakeGame_v._2._0_
{
    partial class DoUWantToExit
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to exit the game?";
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackColor = System.Drawing.Color.Crimson;
            this.btn_Yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Yes.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Yes.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_Yes.Location = new System.Drawing.Point(50, 159);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(138, 57);
            this.btn_Yes.TabIndex = 1;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = false;
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_No.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_No.ForeColor = System.Drawing.Color.Black;
            this.btn_No.Location = new System.Drawing.Point(234, 159);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(138, 57);
            this.btn_No.TabIndex = 2;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = false;
            // 
            // DoUWantToExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(438, 275);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.label1);
            this.Name = "DoUWantToExit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
    }
}