using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class frmCaro : Form
    {
        #region Properties
        ChessBoardManager chessBoard;
        #endregion
        public frmCaro()
        {
            InitializeComponent();
            
        }

        private void frmCaro_Load(object sender, EventArgs e)
        {
            chessBoard = new ChessBoardManager(pnlBanCo);
            chessBoard.drawChessBoard();

        }

        
    }
}
