namespace Survive2020
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnChooseLvl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenSaved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnStart.Location = new System.Drawing.Point(227, 212);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(491, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHowToPlay.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnHowToPlay.Location = new System.Drawing.Point(227, 369);
            this.btnHowToPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(491, 46);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.Text = "How to play";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnChooseLvl
            // 
            this.btnChooseLvl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnChooseLvl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseLvl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseLvl.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseLvl.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnChooseLvl.Location = new System.Drawing.Point(227, 290);
            this.btnChooseLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseLvl.Name = "btnChooseLvl";
            this.btnChooseLvl.Size = new System.Drawing.Size(491, 46);
            this.btnChooseLvl.TabIndex = 2;
            this.btnChooseLvl.Text = "Choose Level";
            this.btnChooseLvl.UseVisualStyleBackColor = false;
            this.btnChooseLvl.Click += new System.EventHandler(this.btnChooseLvl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(197, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "Survive 2020";
            // 
            // btnOpenSaved
            // 
            this.btnOpenSaved.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOpenSaved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenSaved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenSaved.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSaved.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnOpenSaved.Location = new System.Drawing.Point(227, 448);
            this.btnOpenSaved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenSaved.Name = "btnOpenSaved";
            this.btnOpenSaved.Size = new System.Drawing.Size(491, 46);
            this.btnOpenSaved.TabIndex = 4;
            this.btnOpenSaved.Text = "OPEN SAVED GAME";
            this.btnOpenSaved.UseVisualStyleBackColor = false;
            this.btnOpenSaved.Click += new System.EventHandler(this.btnOpenSaved_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Survive2020.Properties.Resources.corona;
            this.ClientSize = new System.Drawing.Size(959, 569);
            this.Controls.Add(this.btnOpenSaved);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseLvl);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(977, 616);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(977, 616);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survive 2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnChooseLvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSaved;
    }
}