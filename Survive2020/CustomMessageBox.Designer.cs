namespace Survive2020
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.lbMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.lbMessage.Location = new System.Drawing.Point(19, 21);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessage.MaximumSize = new System.Drawing.Size(405, 122);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(405, 122);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btnRight.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRight.Location = new System.Drawing.Point(238, 155);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(116, 42);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "Exit game";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btnLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLeft.Location = new System.Drawing.Point(70, 155);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(116, 42);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "Button";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Survive2020.Properties.Resources.corona;
            this.ClientSize = new System.Drawing.Size(433, 216);
            this.ControlBox = false;
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}