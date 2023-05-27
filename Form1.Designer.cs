
namespace YILAN_OYUNU
{
    partial class Snake
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(50, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score : 0";
            // 
            // lblFood
            // 
            this.lblFood.BackColor = System.Drawing.Color.Red;
            this.lblFood.Location = new System.Drawing.Point(350, 98);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(21, 21);
            this.lblFood.TabIndex = 1;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YILAN OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFood;
    }
}

