using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FrmGamePlay fGamePlay = new FrmGamePlay();

            fGamePlay.ShowDialog();
        }
    }
}
