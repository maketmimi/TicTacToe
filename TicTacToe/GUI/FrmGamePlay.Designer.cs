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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "دور اللاعب";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "عبد الرحمن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(39, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.label4.Location = new System.Drawing.Point(128, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "الفائز";
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
            this.BtnReset.Location = new System.Drawing.Point(24, 455);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(133, 53);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "إعادة";
            this.BtnReset.UseVisualStyleBackColor = false;
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
            this.BtnClose.Location = new System.Drawing.Point(176, 455);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(133, 53);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "إغلاق";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(881, 528);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGamePlay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "لعبة إكس أو";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnClose;
    }
}