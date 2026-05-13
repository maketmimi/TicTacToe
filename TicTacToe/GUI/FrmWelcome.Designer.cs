namespace TicTacToe
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.LbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderSize = 3;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(268, 323);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(192, 53);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbout.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAbout.FlatAppearance.BorderSize = 3;
            this.BtnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.Color.White;
            this.BtnAbout.Location = new System.Drawing.Point(268, 251);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(192, 53);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "حول";
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPlay.FlatAppearance.BorderSize = 3;
            this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Location = new System.Drawing.Point(268, 179);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(192, 53);
            this.BtnPlay.TabIndex = 3;
            this.BtnPlay.Text = "العب";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // LbTitle
            // 
            this.LbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTitle.AutoSize = true;
            this.LbTitle.BackColor = System.Drawing.Color.Transparent;
            this.LbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitle.ForeColor = System.Drawing.Color.White;
            this.LbTitle.Location = new System.Drawing.Point(208, 49);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(312, 67);
            this.LbTitle.TabIndex = 4;
            this.LbTitle.Text = "Tic Tac Toe";
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.WelcomeScreenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.LbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmWelcome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label LbTitle;
    }
}

