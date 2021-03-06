﻿using System;

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
            this.pause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
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
            this.lblLevelNumber.Location = new System.Drawing.Point(716, 9);
            this.lblLevelNumber.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLevelNumber.Name = "lblLevelNumber";
            this.lblLevelNumber.Size = new System.Drawing.Size(126, 46);
            this.lblLevelNumber.TabIndex = 1;
            this.lblLevelNumber.Text = "Level";
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(748, 58);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(57, 59);
            this.pause.TabIndex = 2;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.pause);
            this.Controls.Add(this.lblLevelNumber);
            this.Controls.Add(this.lbPoints);
            this.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.Deactivate += new System.EventHandler(this.Game_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Label lblLevelNumber;
        private System.Windows.Forms.PictureBox pause;
    }
}

