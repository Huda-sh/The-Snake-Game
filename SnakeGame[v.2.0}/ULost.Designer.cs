
namespace SnakeGame_v._2._0_
{
    partial class ULost
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
            this.btn_Retry = new System.Windows.Forms.Button();
            this.btn_GTM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 47);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Retry
            // 
            this.btn_Retry.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Retry.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Retry.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retry.ForeColor = System.Drawing.Color.Olive;
            this.btn_Retry.Location = new System.Drawing.Point(259, 176);
            this.btn_Retry.Name = "btn_Retry";
            this.btn_Retry.Size = new System.Drawing.Size(164, 44);
            this.btn_Retry.TabIndex = 4;
            this.btn_Retry.Text = "OK";
            this.btn_Retry.UseVisualStyleBackColor = false;
            // 
            // btn_GTM
            // 
            this.btn_GTM.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_GTM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_GTM.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GTM.ForeColor = System.Drawing.Color.Olive;
            this.btn_GTM.Location = new System.Drawing.Point(50, 176);
            this.btn_GTM.Name = "btn_GTM";
            this.btn_GTM.Size = new System.Drawing.Size(162, 44);
            this.btn_GTM.TabIndex = 3;
            this.btn_GTM.Text = "Start Menue";
            this.btn_GTM.UseVisualStyleBackColor = false;
            // 
            // ULost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame_v._2._0_.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(485, 253);
            this.Controls.Add(this.btn_Retry);
            this.Controls.Add(this.btn_GTM);
            this.Controls.Add(this.label1);
            this.Name = "ULost";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ULost";
            this.Load += new System.EventHandler(this.ULost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Retry;
        private System.Windows.Forms.Button btn_GTM;
    }
}