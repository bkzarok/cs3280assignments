using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Rules
    {

        public Rules(){ }

        public void printBoard()
        {
            
        }
      

        public Boolean checkForWin(char[,] tictac)
        {
            if (checkRowsForWin(tictac) || checkColumnsForWin(tictac) || checkDiagonalsForWin(tictac))
                return true;
            return false;
        }

        private Boolean checkRowCol(int value1, int value2, int value3)
        {
            if ((value1 == value2) && (value1 == value3))
            {
                return true;
            }
            return false;
        }

        private Boolean checkRowsForWin(char[,] tictac)
        {
            for (int i = 0; i < 3; i++)
            {
                if (checkRowCol(tictac[i, 0], tictac[i, 1], tictac[i, 2]))
                    return true;
            }
            return false;
        }

        private Boolean checkColumnsForWin(char[,] tictac)
        {
            for (int i = 0; i < 3; i++)
            {
                if (checkRowCol(tictac[0, i], tictac[1, i], tictac[2,i]))
                    return true;
            }
            return false;
        }

        private Boolean checkDiagonalsForWin(char[,] tictac)
        {
            if (checkRowCol(tictac[0, 0], tictac[1, 1], tictac[2, 2]) || checkRowCol(tictac[0, 2], tictac[1, 1], tictac[2, 0]))
                return true;
            return false;
        }
    }
}
