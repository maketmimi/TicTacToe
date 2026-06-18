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
            this.Hide();

            FrmGamePlay fGamePlay = new FrmGamePlay(TxtPlayer1Name.Text, TxtPlayer2Name.Text);

            fGamePlay.ShowDialog();

            this.Close();
        }

        private void NameField_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox NameField = (TextBox) sender;
            if (string.IsNullOrWhiteSpace(NameField.Text))
            {
                ErrpMain.SetError(NameField, "حقل إجباري!");
                e.Cancel = true;
            }
            else
                ErrpMain.SetError(NameField, null);
        }
        
    }
}
