namespace Survive2020
{
    partial class Pause
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbPause = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSave.Location = new System.Drawing.Point(216, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 52);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lbPause
            // 
            this.lbPause.AutoSize = true;
            this.lbPause.BackColor = System.Drawing.Color.Transparent;
            this.lbPause.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPause.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbPause.Location = new System.Drawing.Point(104, 28);
            this.lbPause.Name = "lbPause";
            this.lbPause.Size = new System.Drawing.Size(428, 74);
            this.lbPause.TabIndex = 4;
            this.lbPause.Text = "Game paused";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnQuit.Location = new System.Drawing.Point(216, 242);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(155, 52);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnBack.Location = new System.Drawing.Point(23, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 75);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "⯇";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // Pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Survive2020.Properties.Resources.corona;
            this.ClientSize = new System.Drawing.Size(567, 378);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lbPause);
            this.Controls.Add(this.btnSave);
            this.Name = "Pause";
            this.Text = "Pause";
            this.Load += new System.EventHandler(this.Pause_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPause;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnBack;
    }
}