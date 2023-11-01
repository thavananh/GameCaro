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

        
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion

        #region Methods
        
        public void drawChessBoard()
        {
            for (int i = 0; i < ConstantAttributes.ROW_NUMBER; i++)
            {
                for (int j = 0; j < ConstantAttributes.COL_NUMBER; j++)
                {
                    Button btn = new Button()
                    {
                        Width = ConstantAttributes.BTNCHESSBOARD_WIDTH,
                        Height = ConstantAttributes.BTNCHESSBOARD_HEIGHT,
                        Location = new Point(j * ConstantAttributes.BTNCHESSBOARD_WIDTH, i * ConstantAttributes.BTNCHESSBOARD_HEIGHT)
                    };
                    btn.Click += btn_Click;
                    chessBoard.Controls.Add(btn);
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = Image.FromFile();
        }
        #endregion
    }
}
