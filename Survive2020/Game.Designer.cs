using System;

namespace Survive2020
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lbPoints = new System.Windows.Forms.Label();
            this.lblLevelNumber = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.BackColor = System.Drawing.Color.Transparent;
            this.lbPoints.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbPoints.Location = new System.Drawing.Point(16, 9);
            this.lbPoints.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(141, 37);
            this.lbPoints.TabIndex = 0;
            this.lbPoints.Text = "Points: ";
            // 
            // lblLevelNumber
            // 
            this.lblLevelNumber.AutoSize = true;
            this.lblLevelNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelNumber.Font = new System.Drawing.Font("Showcard Gothic", 22F);
            this.lblLevelNumber.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblLevelNumber.Location = new System.Drawing.Point(643, 9);
            this.lblLevelNumber.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLevelNumber.Name = "lblLevelNumber";
            this.lblLevelNumber.Size = new System.Drawing.Size(126, 46);
            this.lblLevelNumber.TabIndex = 1;
            this.lblLevelNumber.Text = "Level";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::Survive2020.Properties.Resources.pause_icon1;
            this.btnPause.Location = new System.Drawing.Point(667, 67);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(71, 56);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblLevelNumber);
            this.Controls.Add(this.lbPoints);
            this.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survive 2020";
            this.Activated += new System.EventHandler(this.Game_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause pauseGame = new Pause();
            pauseGame.Show();     
        }

        #endregion

        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lblLevelNumber;
        private System.Windows.Forms.Button btnPause;
    }
}

