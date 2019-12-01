using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    class ChessBoardManager
    {
        #region Properties

        private Panel chessboard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox mark;
        private List<List<Button>> matrix;
        private event EventHandler playerMarked;
        private event EventHandler endedGame;
        private Stack<BeforeTurn> playTimeLine;

        public Panel ChessBoard { get => chessboard; set => chessboard = value; }        
        public List<Player> Player { get => player; set => player = value; }       
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }        
        public TextBox PlayerName { get => playerName; set => playerName = value; }        
        public PictureBox Mark { get => mark; set => mark = value; }      
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }     
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }       
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }        
        public Stack<BeforeTurn> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }

        #endregion

        #region Initialize

        public ChessBoardManager(Panel chessboard, TextBox PlayerName, PictureBox Mark)
        {
            this.ChessBoard = chessboard;
            this.PlayerName = PlayerName;
            this.Mark = Mark;

            this.Player = new List<Player>()
            {
                new Player("P1 (O)",Image.FromFile(Application.StartupPath + "\\Resources\\o.png")),
                new Player("P2 (X)",Image.FromFile(Application.StartupPath + "\\Resources\\x.png"))
            };
        }

        #endregion

        #region Methods

        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            CurrentPlayer = 0;
            NextPLayer();

            PlayTimeLine = new Stack<BeforeTurn>();
            Matrix = new List<List<Button>>();

            Button Oldbtn = new Button { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.ChessBoardHeight; i++)
            {
                for (int j = 0; j < Cons.ChessBoardWidth; j++)
                {
                    Matrix.Add(new List<Button>());

                    Button btn = new Button();
                    btn.Width = Cons.ButtonWidth;
                    btn.Height = Cons.ButtonHeight;
                    btn.Location = new Point(Oldbtn.Location.X + Oldbtn.Width, Oldbtn.Location.Y);
                    btn.Tag = i.ToString();
                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    Oldbtn = btn;
                }
                Oldbtn.Location = new Point(0, Oldbtn.Location.Y + Cons.ButtonHeight);
                Oldbtn.Width = 0;
                Oldbtn.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            NextMark(btn);

            PlayTimeLine.Push(new BeforeTurn(GetChessPoint(btn), CurrentPlayer));

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            NextPLayer();

            if (playerMarked != null)
                playerMarked(this, new EventArgs());

            if (IsEndGame(btn))
            {
                EndGame();
            }
        }

        public bool Undo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;

            BeforeTurn Oldpoint = PlayTimeLine.Pop();
            Button btn = Matrix[Oldpoint.Point.Y][Oldpoint.Point.X];

            btn.BackgroundImage = null;

            if (PlayTimeLine.Count <= 0)
                CurrentPlayer = 0;
            else
                CurrentPlayer = PlayTimeLine.Peek().CurrentPlayer == 1 ? 0 : 1;

            NextPLayer();

            return false;
        }

        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        private bool IsEndGame(Button btn)
        {
            return HorizontalEG(btn) || VerticalEG(btn) || PrimaryDiagonalEG(btn) || SubDiagonalEG(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int y = Convert.ToInt32(btn.Tag);
            int x = Matrix[y].IndexOf(btn);

            Point point = new Point(x, y);

            return point;
        }

        private bool HorizontalEG(Button btn)
        {
            Point point = GetChessPoint(btn);

            int CountLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    CountLeft++;
                else
                    break;
            }

            int CountRight = 0;
            for (int i = point.X + 1; i < Cons.ChessBoardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    CountRight++;
                else
                    break;
            }

            return CountLeft + CountRight == 5;
        }

        private bool VerticalEG(Button btn)
        {
            Point point = GetChessPoint(btn);

            int CountUp = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    CountUp++;
                else
                    break;
            }

            int CountDown = 0;
            for (int i = point.Y + 1; i < Cons.ChessBoardHeight; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    CountDown++;
                else
                    break;
            }

            return CountUp + CountDown == 5;
        }

        private bool PrimaryDiagonalEG(Button btn)
        {
            Point point = GetChessPoint(btn);

            int CountUp = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    CountUp++;
                else
                    break;
            }

            int CountDown = 0;
            for (int i = 1; i < Cons.ChessBoardWidth - point.X; i++)
            {
                if (point.Y + i >= Cons.ChessBoardHeight || point.X + i >= Cons.ChessBoardWidth)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    CountDown++;
                else
                    break;
            }

            return CountUp + CountDown == 5;
        }

        private bool SubDiagonalEG(Button btn)
        {
            Point point = GetChessPoint(btn);

            int CountUp = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.ChessBoardWidth || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    CountUp++;
                else
                    break;
            }

            int CountDown = 0;
            for (int i = 1; i < Cons.ChessBoardWidth - point.X; i++)
            {
                if (point.Y + i >= Cons.ChessBoardHeight || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    CountDown++;
                else
                    break;
            }

            return CountUp + CountDown == 5;
        }

        private void NextMark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void NextPLayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;

            Mark.BackgroundImage = Player[CurrentPlayer].Mark;
            Mark.BackgroundImageLayout = ImageLayout.Stretch;
        }

        #endregion
    }
}