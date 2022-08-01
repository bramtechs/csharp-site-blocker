namespace SiteBlocker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BlockButton = new System.Windows.Forms.Button();
            this.AllowButton = new System.Windows.Forms.Button();
            this.SitesBox = new System.Windows.Forms.RichTextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.viewHostLabel = new System.Windows.Forms.Label();
            this.editHostsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Site Blocker";
            this.NotifyIcon.Visible = true;
            // 
            // BlockButton
            // 
            this.BlockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BlockButton.BackColor = System.Drawing.Color.LightCoral;
            this.BlockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlockButton.Location = new System.Drawing.Point(16, 338);
            this.BlockButton.Margin = new System.Windows.Forms.Padding(4);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(184, 43);
            this.BlockButton.TabIndex = 0;
            this.BlockButton.Text = "Block";
            this.BlockButton.UseVisualStyleBackColor = false;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // AllowButton
            // 
            this.AllowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AllowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllowButton.Location = new System.Drawing.Point(261, 338);
            this.AllowButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllowButton.Name = "AllowButton";
            this.AllowButton.Size = new System.Drawing.Size(188, 43);
            this.AllowButton.TabIndex = 1;
            this.AllowButton.Text = "Allow";
            this.AllowButton.UseVisualStyleBackColor = false;
            this.AllowButton.Click += new System.EventHandler(this.AllowButton_Click);
            // 
            // SitesBox
            // 
            this.SitesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SitesBox.Location = new System.Drawing.Point(16, 16);
            this.SitesBox.Margin = new System.Windows.Forms.Padding(4);
            this.SitesBox.Name = "SitesBox";
            this.SitesBox.Size = new System.Drawing.Size(433, 213);
            this.SitesBox.TabIndex = 2;
            this.SitesBox.Text = "";
            this.SitesBox.TextChanged += new System.EventHandler(this.SitesBox_TextChanged);
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.Yellow;
            this.warningLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.warningLabel.Location = new System.Drawing.Point(17, 276);
            this.warningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(432, 48);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.Text = "Administrator Privileges! Make sure you downloaded the Github version.\r\nYou may n" +
    "eed to restart your browser after blocking sites.\r\nIf you have a customized Host" +
    "s file, edit it via the link above.\r\n";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewHostLabel
            // 
            this.viewHostLabel.AutoSize = true;
            this.viewHostLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewHostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHostLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.viewHostLabel.Location = new System.Drawing.Point(17, 246);
            this.viewHostLabel.Name = "viewHostLabel";
            this.viewHostLabel.Size = new System.Drawing.Size(84, 16);
            this.viewHostLabel.TabIndex = 4;
            this.viewHostLabel.Text = "View host file";
            this.viewHostLabel.Click += new System.EventHandler(this.viewHostLabel_Click);
            // 
            // editHostsLabel
            // 
            this.editHostsLabel.AutoSize = true;
            this.editHostsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editHostsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.editHostsLabel.Location = new System.Drawing.Point(320, 246);
            this.editHostsLabel.Name = "editHostsLabel";
            this.editHostsLabel.Size = new System.Drawing.Size(120, 16);
            this.editHostsLabel.TabIndex = 5;
            this.editHostsLabel.Text = "Edit stock hosts file";
            this.editHostsLabel.Click += new System.EventHandler(this.editHostsLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 396);
            this.Controls.Add(this.editHostsLabel);
            this.Controls.Add(this.viewHostLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.SitesBox);
            this.Controls.Add(this.AllowButton);
            this.Controls.Add(this.BlockButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Site Blocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifyIcon;

        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.Button AllowButton;
        private System.Windows.Forms.RichTextBox SitesBox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label viewHostLabel;
        private System.Windows.Forms.Label editHostsLabel;
    }
}

