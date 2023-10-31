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
        
        public Panel chessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;
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
                    chessBoard.Controls.Add(btn);
                }
            }
        }
        #endregion
    }
}
