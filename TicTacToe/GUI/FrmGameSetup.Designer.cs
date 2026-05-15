namespace TicTacToe.GUI
{
    partial class FrmGameSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGameSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPlayer1Name = new System.Windows.Forms.TextBox();
            this.TxtPlayer2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم اللاعب الأول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPlayer1Name
            // 
            this.TxtPlayer1Name.BackColor = System.Drawing.Color.White;
            this.TxtPlayer1Name.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlayer1Name.Location = new System.Drawing.Point(217, 129);
            this.TxtPlayer1Name.MaxLength = 8;
            this.TxtPlayer1Name.Name = "TxtPlayer1Name";
            this.TxtPlayer1Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPlayer1Name.Size = new System.Drawing.Size(262, 50);
            this.TxtPlayer1Name.TabIndex = 1;
            this.TxtPlayer1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPlayer2Name
            // 
            this.TxtPlayer2Name.BackColor = System.Drawing.Color.White;
            this.TxtPlayer2Name.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlayer2Name.Location = new System.Drawing.Point(217, 322);
            this.TxtPlayer2Name.MaxLength = 8;
            this.TxtPlayer2Name.Name = "TxtPlayer2Name";
            this.TxtPlayer2Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtPlayer2Name.Size = new System.Drawing.Size(262, 50);
            this.TxtPlayer2Name.TabIndex = 3;
            this.TxtPlayer2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم اللاعب الثاني";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPlay.FlatAppearance.BorderSize = 3;
            this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(70)))));
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Location = new System.Drawing.Point(141, 421);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(192, 53);
            this.BtnPlay.TabIndex = 4;
            this.BtnPlay.Text = "العب";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(364, 421);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(192, 53);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmGameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(696, 486);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.TxtPlayer2Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPlayer1Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGameSetup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "إعداد اللعبة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPlayer1Name;
        private System.Windows.Forms.TextBox TxtPlayer2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnClose;
    }
}