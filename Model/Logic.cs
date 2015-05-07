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
            table = new int[100, 100];

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    table[i,j] = 0;
                }
            }

        }
        public void NewGame()
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
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

            //check row
            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                if (table[row, i] == player)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }

                if (counter == 5)
                    return true;
            }

            counter = 0;

            //check column
            for (int i = 0; i < 100; i++)
            {
                if (table[i, col] == player)
                {
                    counter++;

                }
                else
                {
                    counter = 0;
                }
                if (counter == 5)
                    return true;

            }

            counter = 0;

            //check diagonal
            /*for (int i = row + col; i >= 0; i--)
            {
                for (int j = 0; j < row + col; j++)
                {

                    if (table[i, j] == player)
                    {

                        counter++;
                    }
                    else
                    {
                        counter = 0;
                    }

                    if (counter == 5)
                        return true;
                }

            }*/
            

            counter = 0;

            //check anti-diagonal

            if (row >= col)
            {
                for (int i = 0; i < 100 - col + row; i++)
                {
                    for (int j = 0; j < 100 - row; j++)
                    {
                        if (table[i, j] == player)
                        {
                            counter++;
                        }
                        else
                        {
                            counter = 0;
                        }

                        if (counter == 5)
                            return true;
                    }

                }
            }
            else
            {
               
            }

            return false;
        }

    }
}
