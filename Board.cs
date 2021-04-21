using System;
using System.Drawing;

namespace Connect4
{
    public enum Player
    {
        EMPTY, RED, YELLOW
    }
    public class Board
    {
        private const int rows = 6;
        private const int cols = 7;
        private readonly Player[,] board = new Player[rows,cols];

        private Player CurrentPlayer = Player.EMPTY;

        private Player StarterPlayer = Player.YELLOW;

        private readonly Form1 Form;

        private string YellowName;
        private string RedName;

        public Board(Form1 Form)
        {
            //constructor
            ResetBoard();

            this.Form = Form;
        }

        // returns who the winner is as a string
        public string GetWinner()
        {
            if (!CheckWin())
                return null;
            return CurrentPlayer == Player.YELLOW ? YellowName : RedName;
        }

        public void PlaceMark(int Col)
        {
            for (int i = rows-1; i >= 0; i--)
            {
                // Go through each row until we reach an empty part
                // Go to the bottom up
                if (board[i, Col] == Player.EMPTY)
                {
                    board[i, Col] = CurrentPlayer;

                    // Disable the column if that was the last open space.
                    if (i == 0)
                    {
                        Form.DisableColumn(Col+1);
                    }
                    break;
                }
            }

            // Refresh to update the mark
            Form.Refresh();

            // Print the new board
            PrintBoard();

            // get if the game is won
            bool GameWon = CheckWin();

            // check if the game is won
            if (GameWon)
            {
                // let the main form know the game is won
                Form.GameWon();
            }
            else
            {
                // Next turn
                CurrentPlayer = NextTurn();

                // update the current turn label with the next player
                Form.UpdateTurnLabel(CurrentPlayer == Player.YELLOW ? YellowName : RedName);
            }
        }

        private string GetBoardPieceString(Player Player)
        {
            // Yellow = Y
            if (Player == Player.YELLOW)
                return "Y";

            // Red = R
            if (Player == Player.RED)
                return "R";

            // Empty = O
            return "O";
        }

        public void PrintBoard()
        {
            Console.WriteLine();
            Console.WriteLine("Game Board");
            Console.WriteLine("---------");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0)
                        Console.Write("|");

                    // Get the player piece string and print it
                    string PlayerString = GetBoardPieceString(board[i, j]);
                    Console.Write(PlayerString);
                    if (j+1 == cols)
                    {
                        Console.WriteLine("|");
                    }
                }
            }
            Console.WriteLine("---------");
            Console.WriteLine();
        }

        public bool CheckWin()
        {
            int sameInARow = 1;

            // Check any possible horizontal (left to right) 4-in-a-row
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (board[i,j] == board[i,j - 1] && board[i,j] != Player.EMPTY)
                    {
                        sameInARow++;

                        if (sameInARow == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        sameInARow = 1;
                    }
                }
            }

            // Check any possible vertical (up and down) 4-in-a-row
            for (int i = 0; i < cols; i++)
            {
                for (int j = 1; j < rows; j++)
                {
                    if (board[j,i] == board[j - 1,i] && board[j,i] != Player.EMPTY)
                    {
                        sameInARow++;

                        if (sameInARow == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        sameInARow = 1;
                    }
                }
            }

            // Check any possible diagonal 4-in-a-row. This ia a little tricky since the matrix's columns and rows are uneven.

            // High left, low right (\)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i,j] != Player.EMPTY)
                    {
                        Player playerFound = board[i,j];

                        for (int k = 0; k < 4; k++)
                        {
                            // Check if mark index is out of range of matrix size
                            if (i + k >= rows || j + k >= cols)
                            {
                                break;
                            }

                            // It is less than a 4-in-a-row
                            if (board[i + k,j + k] != playerFound)
                            {
                                break;
                            }

                            // If we've gotten to this point, then we've found 4 of the same player marks in a row. Tell the program there is a winner.
                            if (k == 3)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            // High right, low left (/)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i,j] != Player.EMPTY)
                    {
                        Player playerFound = board[i,j];

                        for (int k = 0; k < 4; k++)
                        {
                            // Check if mark index is out of range of matrix size
                            if (i + k >= rows || j - k < 0)
                            {
                                break;
                            }

                            // It is less than a 4-in-a-row
                            if (board[i + k,j - k] != playerFound)
                            {
                                break;
                            }

                            // If we've gotten to this point, then we've found 4 of the same player marks in a row. Tell the program there is a winner.
                            if (k == 3)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public Player NextTurn()
        {
            // Yellow ---> Red
            if (CurrentPlayer == Player.YELLOW)
                return Player.RED;

            // Red ---> Yellow
            if (CurrentPlayer == Player.RED)
                return Player.YELLOW;

            // Empty ---> Whatever is set as the StarterPlayer
            return StarterPlayer;
        }

        public void ResetBoard()
        {
            //reset the game board to empty
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = Player.EMPTY;
                }
            }

            // Reset game control variables
            CurrentPlayer = Player.EMPTY;

        }

        public void StartGame()
        {
            // Start the turns by calling NextTurn()
            CurrentPlayer = NextTurn();

            // Update the current turn label since it is a new game
            Form.UpdateTurnLabel(CurrentPlayer == Player.YELLOW ? YellowName : RedName);
        }

        public string ChangeStarter()
        {
            if (StarterPlayer == Player.YELLOW)
            {
                // Yellow ---> Red
                StarterPlayer = Player.RED;

                // return Yellow for the menu string
                return "Yellow";
            }

            // Red ---> Yellow
            StarterPlayer = Player.YELLOW;

            // Return Red for the menu string
            return "Red";
        }

        public void DrawBoard(Graphics g)
        {
            int start = 50; //board top left corner offset

            g.FillRectangle(Brushes.Navy, start, start, 700, 600);

            //draw the board columns
            for(int i = 100;i<=600;i = i+100)
                g.DrawLine(Pens.White, start + i, start, start + i, start + 600);

            //draw the board rows
            for (int i = 100; i <= 500; i = i + 100)
                g.DrawLine(Pens.White, start, start + i, start + 700, start + i);


            for (int i= 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == Player.RED)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else if (board[i, j] == Player.YELLOW)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.White, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
            }
        }

        public void SetYellowName(string YellowName)
        {
            this.YellowName = YellowName;
        }

        public void SetRedName(string RedName)
        {
            this.RedName = RedName;
        }

        public string GetCurrentPlayerString()
        {
            return CurrentPlayer.ToString();
        }
    }
}
