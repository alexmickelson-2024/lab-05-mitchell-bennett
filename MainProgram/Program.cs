using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace MainProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int MAX_TURNS = 9;

            WriteLine("\n----------------------------------");
            WriteLine("Welcome to tic-tac-toe");
            WriteLine("----------------------------------");
            WriteLine("Players will take turns choosing an unoccupied cell.");
            WriteLine("The first player to get 3 in a row (or column or diagonal) wins!\n");

            char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };

            // will hold the winning player when there is one
            int winner = 0;

            for (int turn = 0; turn < MAX_TURNS; turn++)
            {
                // player X on even turns, player O on odd turns
                char currentPlayer = turn % 2 == 0 ? 'X' : 'O';
                WriteLine($"currentPlayer={currentPlayer}; turn={turn}");
                WriteLine("Current Board: ");
                DisplayBoard(board);
                board = MakeMove(currentPlayer, board);
                if (HasWinner(board))
                {
                    winner = currentPlayer;
                    break;
                }
            }
            DisplayBoard(board);

            // print the game outcome
            if (winner == 'X')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     X wins!    |");
                WriteLine("\\----------------/");
            }
            else if (winner == 'O')
            {
                WriteLine("\n/----------------\\");
                WriteLine($"|     O wins!    |");
                WriteLine("\\----------------/");
            }
            else
            {
                WriteLine("Looks like a draw");
            }
        }


        public static void DisplayBoard(char[] displayBoard)
        {
            WriteLine($"{displayBoard[0]} | {displayBoard[1]} | {displayBoard[2]}");
            WriteLine("---+---+---");
            WriteLine($"{displayBoard[3]} | {displayBoard[4]} | {displayBoard[5]}");
            WriteLine("---+---+---");
            WriteLine($"{displayBoard[6]} | {displayBoard[7]} | {displayBoard[8]}");
        }

        public static int GetMove(string prompt, char[] displayBoard)
        {
            while (true)
            {
                WriteLine(prompt);
                string input = ReadLine();
                if (input.Length == 1)
                {
                    char inputChar = input[0];
                    if (inputChar >= 'a' && inputChar <= 'i')
                    {
                        int offset = inputChar - 'a';
                        if (displayBoard[offset] == inputChar)
                        {
                            return offset;
                        }
                    }
                }
            }
        }

        public static char[] MakeMove(char currentPlayer, char[] displayBoard)
        {
            int index = GetMove("What move do you want to make A-I?", displayBoard);
            displayBoard[index] = currentPlayer;
            return displayBoard;
        }

        public static bool HasWinner(char[] board)
        {
            if (CellsAreTheSame(board[0], board[1], board[2]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[3], board[4], board[5]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[6], board[7], board[8]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[0], board[3], board[6]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[1], board[4], board[7]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[2], board[5], board[8]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[0], board[4], board[8]))
            {
                return true;
            }
            else if (CellsAreTheSame(board[2], board[4], board[6]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CellsAreTheSame(char a, char b, char c)
        {
            return a == b && b == c;
        }


    }

    // TODO: write the functions used in main (and any other helper functions you want to use)

    // DisplayBoard
    /**
     * displays the tic-tac-toe board
     * given the contents of the named cells
     *  a | b | c
     * ---+---+---
     *  d | e | f
     * ---+---+--
     *  g | h | i
     */

    //GetMove
    /* given a string to prompt the user for input, get a cell.
     * The user must enter a single character, 'a' through 'i', that's it.
     * Verify the cell is valid (e.g. it is in the board, and no one has played there yet).         
     * return the index of the cell the player selected (if they want 'a' you'd return 0)
    */

    //HasWinner
    /* given the board,
     * returns true if the board has a winner (8 possibilities: horizontal, vertical, or diagonal)
     */
    // hint: just return true if you can find three-in-a-row
    // of any character; consider writing the function 'CellsAreTheSame'
    // described below

    //bool CellsAreTheSame(char a, char b, char c);
    /**
     *  returns true if a, b, and c are all the same
     */

    //MakeMove
    /**
     * Call GetMove("Where do you want to play?") until player selects an unused cell.
     * Update the board at that index with the current player's symbol.
     */
    //hint: you'll want to pass in the board so that you can change it; 
    // also, you'll probably have a loop in here in case the user selects a 
    // cell that another player already picked.  You'll need to ask again for them to
    // pick another cell.


}

