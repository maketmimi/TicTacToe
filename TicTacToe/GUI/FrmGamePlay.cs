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

        private enum EnGameState
        {
            InProgress,
            GameOver
        }

        private struct StPlayer
        {
            public string Name;
            public EnSymbols Symbol;

            public StPlayer(string name, EnSymbols symbol)
            {
                Name = name;
                Symbol = symbol;
            }

        }

        private readonly StPlayer _XPlayer, _OPlayer;
        private StPlayer _CurrentPlayer;
        private EnGameState _GameState = EnGameState.InProgress;

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

            _XPlayer = new StPlayer(XPlayerName, EnSymbols.X);
            _OPlayer = new StPlayer(OPlayerName, EnSymbols.O);

            _CurrentPlayer = _XPlayer;

            LbCurrentPlayerName.Text = _CurrentPlayer.Name;

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchPlayer()
        {
            if (_CurrentPlayer.Symbol == EnSymbols.X)
                _CurrentPlayer = _OPlayer;
            else
                _CurrentPlayer = _XPlayer;

            LbCurrentPlayerName.Text = _CurrentPlayer.Name;
        }

        private void ShowGameOverMessage()
        {

            MessageBox.Show("انتهت اللعبة!", "انتهت اللعبة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool CheckGameOver()
        {
            bool IsWinner = false;

            if ((EnSymbols) Pb00.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb01.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb02.Tag == _CurrentPlayer.Symbol)
            {
                Pb00.BackColor = Color.Green;
                Pb01.BackColor = Color.Green;
                Pb02.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb10.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb11.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb12.Tag == _CurrentPlayer.Symbol)
            {
                Pb10.BackColor = Color.Green;
                Pb11.BackColor = Color.Green;
                Pb12.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb20.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb21.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb22.Tag == _CurrentPlayer.Symbol)
            {
                Pb20.BackColor = Color.Green;
                Pb21.BackColor = Color.Green;
                Pb22.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb00.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb10.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb20.Tag == _CurrentPlayer.Symbol)
            {
                Pb00.BackColor = Color.Green;
                Pb10.BackColor = Color.Green;
                Pb20.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb01.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb11.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb21.Tag == _CurrentPlayer.Symbol)
            {
                Pb01.BackColor = Color.Green;
                Pb11.BackColor = Color.Green;
                Pb21.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb02.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb12.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb22.Tag == _CurrentPlayer.Symbol)
            {
                Pb02.BackColor = Color.Green;
                Pb12.BackColor = Color.Green;
                Pb22.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb00.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb11.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb22.Tag == _CurrentPlayer.Symbol)
            {
                Pb00.BackColor = Color.Green;
                Pb11.BackColor = Color.Green;
                Pb22.BackColor = Color.Green;
                IsWinner = true;
            }
            else if ((EnSymbols) Pb02.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb11.Tag == _CurrentPlayer.Symbol && (EnSymbols)Pb20.Tag == _CurrentPlayer.Symbol)
            {
                Pb02.BackColor = Color.Green;
                Pb11.BackColor = Color.Green;
                Pb20.BackColor = Color.Green;
                IsWinner = true;
            }

            if (IsWinner)
            {
                LbWinnerName.Text = _CurrentPlayer.Name;
                LbCurrentPlayerName.Text = "انتهت اللعبة";
                _GameState = EnGameState.GameOver;
                ShowGameOverMessage();
                return true;
            }
            else
            {
                if ((EnSymbols) Pb00.Tag != EnSymbols.QuestionMark &&
                    (EnSymbols) Pb01.Tag != EnSymbols.QuestionMark &&
                    (EnSymbols) Pb02.Tag != EnSymbols.QuestionMark &&
                    
                    (EnSymbols) Pb10.Tag != EnSymbols.QuestionMark &&
                    (EnSymbols) Pb11.Tag != EnSymbols.QuestionMark &&
                    (EnSymbols) Pb12.Tag != EnSymbols.QuestionMark &&
                    
                    (EnSymbols) Pb20.Tag != EnSymbols.QuestionMark &&
                    (EnSymbols) Pb21.Tag != EnSymbols.QuestionMark &&
                    (EnSymbols) Pb22.Tag != EnSymbols.QuestionMark)
                {
                    LbWinnerName.Text = "تعادل";
                    LbCurrentPlayerName.Text = "انتهت اللعبة";
                    _GameState = EnGameState.GameOver;
                    ShowGameOverMessage();
                    return true;
                }
            }

            return false;
        }

        private void BoxClicked(object sender, EventArgs e)
        {
            if (_GameState == EnGameState.GameOver) return;

            if (sender is PictureBox PbSender)
            {
                if ((EnSymbols) PbSender.Tag != EnSymbols.QuestionMark)
                {
                    MessageBox.Show("اختيار خاطئ!\nالرجاء اختيار صندوق آخر.",
                        "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (_CurrentPlayer.Symbol)
                {
                    case EnSymbols.X:
                        PbSender.Image = Resources.X_Symbol;
                        PbSender.Tag = EnSymbols.X;
                        break;
                    case EnSymbols.O:
                        PbSender.Image = Resources.O_Symbol;
                        PbSender.Tag = EnSymbols.O;
                        break;
                    default:
                        MessageBox.Show("Some thing went wrong!\nif you saw this you must have done a really bad thing!",
                            "What?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (!CheckGameOver())
                    SwitchPlayer();
            }
        }

        private void ResetGame()
        {
            ResetPictureBoxes();
            _CurrentPlayer = _XPlayer;
            LbCurrentPlayerName.Text = _CurrentPlayer.Name;
            LbWinnerName.Text = "...";
            _GameState = EnGameState.InProgress;
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
