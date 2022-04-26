// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] board = new int[9]; // show 9 tiles
            board[0] = 0;
            board[1] = 0;
            board[2] = 0;
            board[3] = 1;
            board[4] = 2;
            board[5] = 0;
            board[6] = 0;
            board[7] = 0;
            board[8] = 1;

            for (int i = 0; i < 9; i++)
            {
                // print the board.
                // Console.WriteLine("Square " + i + " contains " + board[i]);

                // print x or o for each sqaure
                // 0 means unoccupied. 1 means player 1 (X) 2 means player 2 (O)

                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("X");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }

                //print a new line every 3rd character
                if (i == 2 || i == 5 || i ==8)
                {
                    Console.WriteLine("");
                }



            }



        }
    }
}