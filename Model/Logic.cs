using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class Logic
    {
        private int[,] table;
        private int row;
        private int col;
        private int player;

        public const int SIZE = 50;

        public Logic()
        {
            table = new int[SIZE, SIZE];

            NewGame();

        }
        public void NewGame()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    table[i, j] = 0;
                }
            }
        }

        public void UpdateTable(int actRow, int actCol, int actPlayer)
        {
            row = actRow;
            col = actCol;
            player = actPlayer;

            table[row, col] = player;

        }

        public Boolean IsGameOver()
        {

            if (IsRow())
                return true;

            if (IsCol())
                return true;

            if (IsDiagonal())
                return true;

            if (IsAntiDiagonal())
                return true;

            return false;
        }

        private Boolean IsRow()
        {
            
            int counter = 0;
            int i = row;
            int j = col;

            //check row to the right
            while (j <= SIZE && table[i, j] == player)
            {
                counter++;
                j++;
            }

            //back to left of the latest piece position (we don't count the original piece twice)
            j = col - 1;

            //check row to the left
            while (0 <= j && table[i, j] == player)
            {

                counter++;
                j--;
            }

            if (counter >= 5)
                return true;

            return false;
        }

        private Boolean IsCol()
        {

            int i = row;
            int j = col;
            int counter = 0;

            //check column upwards
            while (i >= 0 && table[i, j] == player)
            {
                counter++;
                i--;
            }

            //back to one piece under the original piece
            i = row + 1;

            //check column downwards
            while (i <= SIZE && table[i, j] == player)
            {
                counter++;
                i++;
            }

            if (counter >= 5)
                return true;


            return false;
        }

        private Boolean IsDiagonal()
        {
            int counter = 0;
            int i = row;
            int j = col;

            //check diagonal upwards
            while (i >= 0 && j <= SIZE && table[i, j] == player)
            {
                counter++;
                i--;
                j++;
            }

            //back to one pice under and left of original piece 
            i = row + 1;
            j = col - 1;

            //check diagonal downwards
            while (i <= SIZE && j >= 0 && table[i, j] == player)
            {
                counter++;
                i++;
                j--;
            }

            if (counter >= 5)
                return true;

            return false;
        }

        private Boolean IsAntiDiagonal()
        {
            int counter = 0;
            int i = row;
            int j = col;


            //check antidiagonal upwards
            while (i >= 0 && j >= 0 && table[i, j] == player)
            {
                counter++;
                i--;
                j--;
            }

            //back to one piece under and right of original piece
            i = row + 1;
            j = col + 1;

            //check antidiagonal downwards and right
            while (i <= SIZE && j <= SIZE && table[i, j] == player)
            {
                counter++;
                i++;
                j++;
            }

            if (counter >= 5)
                return true;


            return false;
        }

    }
}
