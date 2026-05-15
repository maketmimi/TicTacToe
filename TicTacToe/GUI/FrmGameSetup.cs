using System;
using System.Windows.Forms;

namespace TicTacToe.GUI
{
    public partial class FrmGameSetup : Form
    {
        public FrmGameSetup()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtPlayer1Name.Text) || String.IsNullOrEmpty(TxtPlayer2Name.Text))
            {
                MessageBox.Show("لا يمكن ترك الحقول فارغة!", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();

            FrmGamePlay fGamePlay = new FrmGamePlay(TxtPlayer1Name.Text, TxtPlayer2Name.Text);

            fGamePlay.ShowDialog();

            this.Close();
        }
    }
}
