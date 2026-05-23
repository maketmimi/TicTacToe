using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe.GUI
{
    public partial class FrmGamePlay : Form
    {
        private enum EnSymbols
        {
            X,
            O,
            QuestionMark
        }

        private enum EnWinner
        {
            XPlayer,
            OPlayer,
            Draw,
            InProgress
        }

        private enum EnPlayer
        {
            XPlayer,
            OPlayer
        }

        private struct StGameState
        {
            public EnWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }

        private readonly string _XPlayerName, _OPlayerName;
        private EnPlayer _PlayerTurn;
        private StGameState _GameStatus;

        private void ResetPictureBox(PictureBox Pb)
        {
            Pb.Tag = EnSymbols.QuestionMark;
            Pb.Image = Resources.QuestionMark;
            Pb.BackColor = Color.Transparent;
        }

        private void ResetPictureBoxes()
        {
            ResetPictureBox(Pb00);
            ResetPictureBox(Pb01);
            ResetPictureBox(Pb02);
            
            ResetPictureBox(Pb10);
            ResetPictureBox(Pb11);
            ResetPictureBox(Pb12);
            
            ResetPictureBox(Pb20);
            ResetPictureBox(Pb21);
            ResetPictureBox(Pb22);
        }

        public FrmGamePlay(string XPlayerName, string OPlayerName)
        {
            InitializeComponent();
            ResetPictureBoxes();

            _XPlayerName = XPlayerName;
            _OPlayerName = OPlayerName;

            _PlayerTurn = EnPlayer.XPlayer;
            LbCurrentPlayerName.Text = _XPlayerName;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowGameOverMessage()
        {

            MessageBox.Show("انتهت اللعبة!", "انتهت اللعبة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void EndGame()
        {
            _GameStatus.GameOver = true;

            switch (_GameStatus.Winner)
            {
                case EnWinner.XPlayer:
                    LbWinnerName.Text = _XPlayerName;
                    break;
                case EnWinner.OPlayer:
                    LbWinnerName.Text = _OPlayerName;
                    break;
                case EnWinner.Draw:
                    LbWinnerName.Text = "تعادل";
                    break;
            }

            LbCurrentPlayerName.Text = "انتهت اللعبة";
            ShowGameOverMessage();
        }

        private bool CheckValues(PictureBox Pb1, PictureBox Pb2, PictureBox Pb3)
        {
            if (((EnSymbols)Pb1.Tag) != EnSymbols.QuestionMark
            && ((EnSymbols)Pb1.Tag) == ((EnSymbols)Pb2.Tag)
            && ((EnSymbols)Pb1.Tag) == ((EnSymbols)Pb3.Tag))
            {
                Pb1.BackColor = Color.Green;
                Pb2.BackColor = Color.Green;
                Pb3.BackColor = Color.Green;

                switch ((EnSymbols) Pb1.Tag)
                {
                    case EnSymbols.X:
                        _GameStatus.Winner = EnWinner.XPlayer;
                        break;
                    case EnSymbols.O:
                        _GameStatus.Winner = EnWinner.OPlayer;
                        break;
                }

                EndGame();
                return true;
            }

            return false;
        }

        private void CheckWinner()
        {
            if (CheckValues(Pb00, Pb01, Pb02))
                return;
            if (CheckValues(Pb10, Pb11, Pb12))
                return;
            if (CheckValues(Pb20, Pb21, Pb22))
                return;

            if (CheckValues(Pb00, Pb10, Pb20))
                return;
            if (CheckValues(Pb01, Pb11, Pb21))
                return;
            if (CheckValues(Pb02, Pb12, Pb22))
                return;

            if (CheckValues(Pb00, Pb11, Pb22))
                return;
            if (CheckValues(Pb02, Pb11, Pb20))
                return;

            if (_GameStatus.PlayCount == 9)
            {
                _GameStatus.Winner = EnWinner.Draw;
                EndGame();
            }

        }

        private void ChangePicture(PictureBox pictureBox)
        {
            if ((EnSymbols)pictureBox.Tag != EnSymbols.QuestionMark)
            {
                MessageBox.Show("اختيار خاطئ!\nالرجاء اختيار صندوق آخر.",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (_PlayerTurn)
            {
                case EnPlayer.XPlayer:
                    pictureBox.Image = Resources.X_Symbol;
                    pictureBox.Tag = EnSymbols.X;
                    _PlayerTurn = EnPlayer.OPlayer;
                    LbCurrentPlayerName.Text = _OPlayerName;
                    break;
                case EnPlayer.OPlayer:
                    pictureBox.Image = Resources.O_Symbol;
                    pictureBox.Tag = EnSymbols.O;
                    _PlayerTurn = EnPlayer.XPlayer;
                    LbCurrentPlayerName.Text = _XPlayerName;
                    break;
            }

            _GameStatus.PlayCount++;
        }

        private void BoxClicked(object sender, EventArgs e)
        {
            if (_GameStatus.GameOver) return;

            ChangePicture((PictureBox) sender);

            CheckWinner();
        }

        private void ResetGame()
        {
            ResetPictureBoxes();
            _GameStatus = new StGameState();
            _PlayerTurn = EnPlayer.XPlayer;
            LbCurrentPlayerName.Text = _XPlayerName;
            LbWinnerName.Text = "...";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void FrmGamePlay_Paint(object sender, PaintEventArgs e)
        {
            // darw grid
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen gridPen = new Pen(Color.FromArgb(150, 170, 210), 15);

            gridPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            gridPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            g.DrawLine(gridPen, 22, 184, 496, 184);
            g.DrawLine(gridPen, 22, 351, 496, 351);

            g.DrawLine(gridPen, 175, 31, 175, 505);
            g.DrawLine(gridPen, 342, 31, 342, 505);
        }
        
    }
}
