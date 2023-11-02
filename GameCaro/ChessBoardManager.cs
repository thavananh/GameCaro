using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        public List<Player> PlayerList { get => playerList; set => playerList = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private List<Player> playerList;

        private int currentPlayer;

        private TextBox playerName;

        private PictureBox playerMark;

        private List<List<Button>> matrix;

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox playerMark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = playerMark;
            this.PlayerList = new List<Player>()
            {
                new Player("HowKteam", Image.FromFile(Application.StartupPath + "\\Resources\\5.png")),
                new Player("Education", Image.FromFile(Application.StartupPath + "\\Resources\\7.jpg")),
            };       //Tự phát triển tính năng cho phép thay đổi tên người chơi, thay đổi avatar
            CurrentPlayer = 0;
        }
        #endregion

        #region Methods

        public void drawChessBoard()
        {
            Matrix = new List<List<Button>>();
            for (int i = 0; i < ConstantAttributes.ROW_NUMBER; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < ConstantAttributes.COL_NUMBER; j++)
                {
                    Button btn = new Button()
                    {
                        Width = ConstantAttributes.BTNCHESSBOARD_WIDTH,
                        Height = ConstantAttributes.BTNCHESSBOARD_HEIGHT,
                        Location = new Point(j * ConstantAttributes.BTNCHESSBOARD_WIDTH, i * ConstantAttributes.BTNCHESSBOARD_HEIGHT),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += btn_Click;
                    chessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackgroundImage != null)
            {
                return;

            }
            btn.BackgroundImage = PlayerList[CurrentPlayer].Mark;
            if (isEndGame(btn))
            {
                endGame();
            }
            if (CurrentPlayer == 1)
            {
                CurrentPlayer = 0;
            }
            else
            {
                CurrentPlayer = 1;
            }
            PlayerName.Text = PlayerList[CurrentPlayer].Name;
            PlayerMark.BackgroundImage = PlayerList[CurrentPlayer].Mark;
            PlayerMark.BackgroundImageLayout = ImageLayout.Stretch;

            
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndPrimary(btn) || isEndVertical(btn) || isEndSub(btn);
        }


        private Point getChessPoint(Button btn)
        {

            int vertical = Convert.ToInt32(btn.Tag); // lấy hàng
            int horizontal = Matrix[vertical].IndexOf(btn); // lấy ô
            Point point = new Point(horizontal, vertical);
            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = getChessPoint(btn);

            int countLeft = 0;
            int countRight = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.X + 1; i < ConstantAttributes.COL_NUMBER; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                {
                    break;
                }
            }

            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = getChessPoint(btn);
            int countUp = 0;
            int countDown = 0;

            for (int i = point.Y; i >= 0; i--)          // X là cột, Y là hàng
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countUp++;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.Y + 1; i < ConstantAttributes.ROW_NUMBER; i++)
            {
                if (matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else
                {
                    break;
                }
            }
            return countUp + countDown == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = getChessPoint(btn);
            int coụntDiagonalLineUp = 0;
            int countDiagonalLineDown = 0;
            // X là cột, Y là hàng
            for (int i = point.X, j = point.Y; i >= 0 && j >= 0; i--, j--)
            {
                if (matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    coụntDiagonalLineUp++;
                }
                else
                {
                    break;
                }    
            }
            for (int i = point.X + 1, j = point.Y + 1; i < ConstantAttributes.COL_NUMBER && j < ConstantAttributes.ROW_NUMBER; i++, j++)
            {
                if (matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countDiagonalLineDown++;
                }
                else
                {
                    break;
                }
            }
            return countDiagonalLineDown + coụntDiagonalLineUp == 5;
        }
        private bool isEndSub(Button btn)
        {
            Point point = getChessPoint(btn);
            int countDiagonalLineUp = 0;
            int countDiagonalLineDown = 0;
            // X là cột, Y là hàng
            for (int i = point.X, j = point.Y; i < ConstantAttributes.COL_NUMBER && j >= 0; i++, j--)
            {
                if (matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countDiagonalLineUp++;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.X - 1, j = point.Y + 1; i >= 0 && j < ConstantAttributes.ROW_NUMBER; i--, j++)
            {
                if (matrix[j][i].BackgroundImage == btn.BackgroundImage)
                {
                    countDiagonalLineDown++;
                }
                else
                {
                    break;
                }
            }
            return countDiagonalLineDown + countDiagonalLineUp == 5;
        }
        private void endGame()
        {
            MessageBox.Show(PlayerList[currentPlayer].Name + "Đã thắng");
            
        }

        #endregion
    }
}
