namespace TicTacToe.GUI
{
    partial class FrmGamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGamePlay));
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LbWinnerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbCurrentPlayerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pb22 = new System.Windows.Forms.PictureBox();
            this.Pb21 = new System.Windows.Forms.PictureBox();
            this.Pb20 = new System.Windows.Forms.PictureBox();
            this.Pb12 = new System.Windows.Forms.PictureBox();
            this.Pb11 = new System.Windows.Forms.PictureBox();
            this.Pb10 = new System.Windows.Forms.PictureBox();
            this.Pb02 = new System.Windows.Forms.PictureBox();
            this.Pb01 = new System.Windows.Forms.PictureBox();
            this.Pb00 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb00)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.BorderSize = 3;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(575, 449);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnClose.Size = new System.Drawing.Size(133, 53);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Transparent;
            this.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnReset.FlatAppearance.BorderSize = 3;
            this.BtnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(724, 449);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnReset.Size = new System.Drawing.Size(133, 53);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "إعادة";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LbWinnerName
            // 
            this.LbWinnerName.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWinnerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.LbWinnerName.Location = new System.Drawing.Point(586, 284);
            this.LbWinnerName.Name = "LbWinnerName";
            this.LbWinnerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbWinnerName.Size = new System.Drawing.Size(263, 62);
            this.LbWinnerName.TabIndex = 19;
            this.LbWinnerName.Text = "...";
            this.LbWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(675, 224);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "الفائز";
            // 
            // LbCurrentPlayerName
            // 
            this.LbCurrentPlayerName.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCurrentPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.LbCurrentPlayerName.Location = new System.Drawing.Point(586, 105);
            this.LbCurrentPlayerName.Name = "LbCurrentPlayerName";
            this.LbCurrentPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LbCurrentPlayerName.Size = new System.Drawing.Size(263, 62);
            this.LbCurrentPlayerName.TabIndex = 17;
            this.LbCurrentPlayerName.Text = "N/A";
            this.LbCurrentPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(638, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "دور اللاعب";
            // 
            // Pb22
            // 
            this.Pb22.BackColor = System.Drawing.Color.Transparent;
            this.Pb22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb22.Image = ((System.Drawing.Image)(resources.GetObject("Pb22.Image")));
            this.Pb22.Location = new System.Drawing.Point(22, 365);
            this.Pb22.Name = "Pb22";
            this.Pb22.Size = new System.Drawing.Size(140, 140);
            this.Pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb22.TabIndex = 15;
            this.Pb22.TabStop = false;
            this.Pb22.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb21
            // 
            this.Pb21.BackColor = System.Drawing.Color.Transparent;
            this.Pb21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb21.Image = ((System.Drawing.Image)(resources.GetObject("Pb21.Image")));
            this.Pb21.Location = new System.Drawing.Point(189, 365);
            this.Pb21.Name = "Pb21";
            this.Pb21.Size = new System.Drawing.Size(140, 140);
            this.Pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb21.TabIndex = 14;
            this.Pb21.TabStop = false;
            this.Pb21.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb20
            // 
            this.Pb20.BackColor = System.Drawing.Color.Transparent;
            this.Pb20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb20.Image = ((System.Drawing.Image)(resources.GetObject("Pb20.Image")));
            this.Pb20.Location = new System.Drawing.Point(356, 365);
            this.Pb20.Name = "Pb20";
            this.Pb20.Size = new System.Drawing.Size(140, 140);
            this.Pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb20.TabIndex = 13;
            this.Pb20.TabStop = false;
            this.Pb20.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb12
            // 
            this.Pb12.BackColor = System.Drawing.Color.Transparent;
            this.Pb12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb12.Image = ((System.Drawing.Image)(resources.GetObject("Pb12.Image")));
            this.Pb12.Location = new System.Drawing.Point(22, 198);
            this.Pb12.Name = "Pb12";
            this.Pb12.Size = new System.Drawing.Size(140, 140);
            this.Pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb12.TabIndex = 12;
            this.Pb12.TabStop = false;
            this.Pb12.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb11
            // 
            this.Pb11.BackColor = System.Drawing.Color.Transparent;
            this.Pb11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb11.Image = ((System.Drawing.Image)(resources.GetObject("Pb11.Image")));
            this.Pb11.Location = new System.Drawing.Point(189, 198);
            this.Pb11.Name = "Pb11";
            this.Pb11.Size = new System.Drawing.Size(140, 140);
            this.Pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb11.TabIndex = 11;
            this.Pb11.TabStop = false;
            this.Pb11.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb10
            // 
            this.Pb10.BackColor = System.Drawing.Color.Transparent;
            this.Pb10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb10.Image = ((System.Drawing.Image)(resources.GetObject("Pb10.Image")));
            this.Pb10.Location = new System.Drawing.Point(356, 198);
            this.Pb10.Name = "Pb10";
            this.Pb10.Size = new System.Drawing.Size(140, 140);
            this.Pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb10.TabIndex = 10;
            this.Pb10.TabStop = false;
            this.Pb10.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb02
            // 
            this.Pb02.BackColor = System.Drawing.Color.Transparent;
            this.Pb02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb02.Image = ((System.Drawing.Image)(resources.GetObject("Pb02.Image")));
            this.Pb02.Location = new System.Drawing.Point(22, 31);
            this.Pb02.Name = "Pb02";
            this.Pb02.Size = new System.Drawing.Size(140, 140);
            this.Pb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb02.TabIndex = 9;
            this.Pb02.TabStop = false;
            this.Pb02.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb01
            // 
            this.Pb01.BackColor = System.Drawing.Color.Transparent;
            this.Pb01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb01.Image = ((System.Drawing.Image)(resources.GetObject("Pb01.Image")));
            this.Pb01.Location = new System.Drawing.Point(189, 31);
            this.Pb01.Name = "Pb01";
            this.Pb01.Size = new System.Drawing.Size(140, 140);
            this.Pb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb01.TabIndex = 8;
            this.Pb01.TabStop = false;
            this.Pb01.Click += new System.EventHandler(this.BoxClicked);
            // 
            // Pb00
            // 
            this.Pb00.BackColor = System.Drawing.Color.Transparent;
            this.Pb00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pb00.Image = ((System.Drawing.Image)(resources.GetObject("Pb00.Image")));
            this.Pb00.Location = new System.Drawing.Point(356, 31);
            this.Pb00.Name = "Pb00";
            this.Pb00.Size = new System.Drawing.Size(140, 140);
            this.Pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb00.TabIndex = 7;
            this.Pb00.TabStop = false;
            this.Pb00.Click += new System.EventHandler(this.BoxClicked);
            // 
            // FrmGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(881, 528);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LbWinnerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbCurrentPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pb22);
            this.Controls.Add(this.Pb21);
            this.Controls.Add(this.Pb20);
            this.Controls.Add(this.Pb12);
            this.Controls.Add(this.Pb11);
            this.Controls.Add(this.Pb10);
            this.Controls.Add(this.Pb02);
            this.Controls.Add(this.Pb01);
            this.Controls.Add(this.Pb00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGamePlay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "لعبة إكس أو";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmGamePlay_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pb00;
        private System.Windows.Forms.PictureBox Pb01;
        private System.Windows.Forms.PictureBox Pb02;
        private System.Windows.Forms.PictureBox Pb12;
        private System.Windows.Forms.PictureBox Pb11;
        private System.Windows.Forms.PictureBox Pb10;
        private System.Windows.Forms.PictureBox Pb22;
        private System.Windows.Forms.PictureBox Pb21;
        private System.Windows.Forms.PictureBox Pb20;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label LbWinnerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbCurrentPlayerName;
        private System.Windows.Forms.Label label1;
    }
}