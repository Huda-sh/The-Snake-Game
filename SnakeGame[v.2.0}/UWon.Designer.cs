
namespace SnakeGame_v._2._0_
{
    partial class UWon
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
            this.btn_GTM = new System.Windows.Forms.Button();
            this.btn_NextLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congrats!... You Won!!";
            // 
            // btn_GTM
            // 
            this.btn_GTM.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_GTM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_GTM.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GTM.ForeColor = System.Drawing.Color.Olive;
            this.btn_GTM.Location = new System.Drawing.Point(49, 173);
            this.btn_GTM.Name = "btn_GTM";
            this.btn_GTM.Size = new System.Drawing.Size(162, 44);
            this.btn_GTM.TabIndex = 1;
            this.btn_GTM.Text = "Start Menue";
            this.btn_GTM.UseVisualStyleBackColor = false;
            // 
            // btn_NextLevel
            // 
            this.btn_NextLevel.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_NextLevel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_NextLevel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextLevel.ForeColor = System.Drawing.Color.Olive;
            this.btn_NextLevel.Location = new System.Drawing.Point(264, 173);
            this.btn_NextLevel.Name = "btn_NextLevel";
            this.btn_NextLevel.Size = new System.Drawing.Size(164, 44);
            this.btn_NextLevel.TabIndex = 2;
            this.btn_NextLevel.Text = "Next Level";
            this.btn_NextLevel.UseVisualStyleBackColor = false;
            // 
            // UWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(485, 253);
            this.Controls.Add(this.btn_NextLevel);
            this.Controls.Add(this.btn_GTM);
            this.Controls.Add(this.label1);
            this.Name = "UWon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UWon";
            this.Load += new System.EventHandler(this.UWon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GTM;
        private System.Windows.Forms.Button btn_NextLevel;
    }
}