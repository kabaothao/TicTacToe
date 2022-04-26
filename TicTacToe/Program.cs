// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] board = new int[9]; //they're 9 tiles
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
                Console.WriteLine("Square " + i " contains " + board);
            }



        }
    }
}