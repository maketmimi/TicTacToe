using System;
using System.Windows.Forms;
using TicTacToe.GUI;

namespace TicTacToe
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FrmAboutScreen about = new FrmAboutScreen();

            about.ShowDialog();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            FrmGameSetup fSetup = new FrmGameSetup();

            this.Hide();

            fSetup.ShowDialog();

            this.Show();
        }
    }
}
