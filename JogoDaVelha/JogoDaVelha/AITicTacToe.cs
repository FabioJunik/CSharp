using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    class AITicTacToe
    {

        public AITicTacToe() {
            InitBoard();
        }

        List<int> indexWin = new List<int>(new int[]{0,0,0});
        List<Player> Board = new List<Player>();
        List<Player> TemporaryBoard = new List<Player>();
        public enum Player { 
            X,
            O,
            S
        }

        private Player turn;

        public List<Player> getBoard() 
        {
            return Board;
        }

        public List<int> getIndices() {
            return indexWin;
        }

        public void clearIndices() {
            indexWin[0] = 0;
            indexWin[1] = 0;
            indexWin[2] = 0;
        }

        public void InitBoard() {
            Board.Clear();
            for (int i = 0; i < 9; i++)
            {
                Board.
                    Add(Player.S);
            }
        }

        public void setValueOnBoard(int index) 
        {
            Board[index]=this.getAttacker();
        }

        public void getNextAttacker()
        {

           turn = (turn == Player.X) ? Player.O : Player.X;
        }


        public Player getAttacker()
        {
            return turn;
        }

        public void setAttacker(Player player)
        {
            this.turn = player;
        }

        public Boolean HasWinner(List<Player> tempBoard)
        {
            if (this.checkDiagonal(tempBoard) || this.checkHorizontal(tempBoard) || this.checkVertical(tempBoard)) {
                return true;
            }
            return false;
        }

        public Boolean isDraw(List<Player> tempBoard)
        {
            int ctr = 0;
            foreach (Player player in tempBoard) {
                if (player == Player.S) {
                    ctr++;
                }
            }
            return (ctr == 0) ? true: false;
        }

        private Boolean checkDiagonal(List<Player> tempBoard)
        {
            if (tempBoard[0] == tempBoard[4] && tempBoard[0] == tempBoard[8])
            {
                if (tempBoard[0] != Player.S)
                {
                    indexWin[0] = 0;
                    indexWin[1] = 4;
                    indexWin[2] = 8;
                    return true;
                }
            }
            if (tempBoard[2] == tempBoard[4] && tempBoard[2] == tempBoard[6])
            {
                if (tempBoard[2] != Player.S)
                {
                    indexWin[0] = 2;
                    indexWin[1] = 4;
                    indexWin[2] = 6;
                    return true;
                }
            }
            return false;
        }

        private Boolean checkHorizontal(List<Player> tempBoard){
            // check if Board[0],Board[1] and Board[2] are equals
            if (tempBoard[0] == tempBoard[1] && tempBoard[0] == tempBoard[2])
            {
                if (tempBoard[0] != Player.S) {
                    indexWin[0] = 0;
                    indexWin[1] = 1;
                    indexWin[2] = 2;
                    return true;
                }
            }

            if (tempBoard[3] == tempBoard[4] && tempBoard[3] == tempBoard[5])
            {
                if (tempBoard[3] != Player.S)
                {
                    indexWin[0] = 3;
                    indexWin[1] = 4;
                    indexWin[2] = 5;
                    return true;
                }
            }

            if (tempBoard[6] == tempBoard[7] && tempBoard[6] == tempBoard[8])
            {
                if (tempBoard[6] != Player.S)
                {
                    indexWin[0] = 6;
                    indexWin[1] = 7;
                    indexWin[2] = 8;
                    return true;
                }
            }

            return false;
        }

        private Boolean checkVertical(List<Player> tempBoard)
        {
            if (tempBoard[0] == tempBoard[3] && tempBoard[0] == tempBoard[6])
            {
                if (tempBoard[0] != Player.S)
                {
                    indexWin[0] = 0;
                    indexWin[1] = 3;
                    indexWin[2] = 6;
                    return true;
                }
            }

            if (tempBoard[1] == tempBoard[4] && tempBoard[1] == tempBoard[7])
            {
                if (tempBoard[1] != Player.S)
                {
                    indexWin[0] = 1;
                    indexWin[1] = 4;
                    indexWin[2] = 7;
                    return true;
                }
            }

            if (tempBoard[2] == tempBoard[5] && tempBoard[2] == tempBoard[8])
            {
                if (tempBoard[2] != Player.S)
                {
                    indexWin[0] = 2;
                    indexWin[1] = 5;
                    indexWin[2] = 8;
                    return true;
                }
            }
            return false;
        }


        public List<int> getAvailableCells(List<Player> tempBoard)
        {
            List<int> getCells = new List<int>();
            int ctr = 0;
            foreach (Player player in tempBoard)
            {
                if (player == Player.S)
                {
                    getCells.
                        Add(ctr);
                }
                ctr++;
            }
            return getCells;
        }

    }
}
