using BoardLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacGUI
{
    public partial class Form1 : Form
    {

        Board game = new Board();
        Button[] buttons = new Button[9];
        Random rand = new Random();




        public Form1()
        {
            InitializeComponent();
            game = new Board();

            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            // add common click event to each button
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonclick;
                buttons[i].Tag = i;
            }


        }

        private void handleButtonclick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show("button " + clickedButton.Tag + " was clicked");

            int gameSquareNumber = (int)clickedButton.Tag;

            game.Grid[gameSquareNumber] = 1;

            updateBoard();

            if (game.isBoardFull() == true)
            {
                MessageBox.Show("The board is full.");
                disableAllButtons();
            }
            else if (game.checkForWinner() == 1)
            {
                MessageBox.Show("Player human wins!");
                disableAllButtons();

            }
            else
                // computer turn
                computerChoose();
       

        }

        private void disableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = false;
            }
        }

        private void computerChoose()
        {

            int computerTurn = rand.Next(9);

            // computer picks a random number. update game.Grid to reflect the choice.
            //don't let the computer pick an invalid number
            // get a random move from the computer
            while (computerTurn == -1 || game.Grid[computerTurn] != 0)
            {
                computerTurn = rand.Next(8); //pick a random number 
                Console.WriteLine("Computer chooses " + computerTurn);
            }
            game.Grid[computerTurn] = 2; //assign to the board
            updateBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }

        private void updateBoard()
        {
            //assign an x or o to the text of each button based on the values in Board
            for (int i = 0; i < game.Grid.Length; i++)
            {
                if (game.Grid[i] == 0)
                {
                    buttons[i].Text = "";
                }
                else if (game.Grid[i] == 1)
                {
                    buttons[i].Text = "X";
                }
                else if (game.Grid[i] == 2)
                {
                    buttons[i].Text = "O";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
