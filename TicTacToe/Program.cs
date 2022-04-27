// See https://aka.ms/new-console-template for more information

using BoardLogic;
using System;

namespace TicTacToe // Note: actual namespace depends on the project name.
{
    public class Program
    {

        // board is the data store for the game
        static Board game = new Board();


        static void Main(string[] args)
        {

            //set up some undefines values
            int userTurn= -1;
            int computerTurn= -1;

            Random rand = new Random(); //the computer will choose something for you. 

            // keep playing until someone wins
            while (game.checkForWinner() == 0) 
            {
                // don't allow the human to choose an already occupied square
                // get valid input from the user 
                while (userTurn == -1 || game.Grid[userTurn] != 0)
                {
                    Console.WriteLine("Please enter a number from 0 to 8");
                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("You typed " + userTurn);
                }

                game.Grid[userTurn] = 1;

                if (game.isBoardFull())
                    break;



                //don't let the computer pick an invalid number
                // get a random move from the computer
                while(computerTurn == -1 || game.Grid[computerTurn] != 0)
                {
                    computerTurn = rand.Next(8); //pick a random number 
                    Console.WriteLine("Computer chooses " + computerTurn);
                }
                game.Grid[computerTurn] = 2; //assign to the board

                // show the board
                printBoard();

            }

            // while is done
            Console.WriteLine("The game is over. Player " + game.checkForWinner() +  " is the winner");
            Console.ReadLine();

            //Console.WriteLine("Player " + checkForWinner() +  " won the game!");

           



        }



        private static void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                // print the board.
                // Console.WriteLine("Square " + i + " contains " + board[i]);

                // print x or o for each sqaure
                // 0 means unoccupied. 1 means player 1 (X) 2 means player 2 (O)

                if (game.Grid[i] == 0)
                {
                    Console.Write(".");
                }
                if (game.Grid[i] == 1)
                {
                    Console.Write("X");
                }
                if (game.Grid[i] == 2)
                {
                    Console.Write("O");
                }

                //print a new line every 3rd character
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine("");
                }

            }

            Console.WriteLine("...----------------------------------");
        }

    }
}