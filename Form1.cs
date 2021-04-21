// Name: Gene Pressinger
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        private Board board;

        public Form1()
        {
            InitializeComponent();
            
            //adds the event handler for when the screen is painted
            Paint += new PaintEventHandler(pic_board_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets called when the main form is loaded
            board = new Board(this);

            // Get the name for Yellow
            UserInput Input = new UserInput("Enter a name for Yellow.", board);
            Input.ShowDialog();

            // Get the name for Red
            Input = new UserInput("Enter a name for Red.", board);
            Input.ShowDialog();

            // Start the game
            board.StartGame();
        }

        private void pic_board_Paint(object sender, PaintEventArgs e)
        {
            //gets called whenever the screen is painted
            board.DrawBoard(e.Graphics);
        }

        private void btn_col1_Click(object sender, EventArgs e)
        {
            // place a mark at column index 0
            board.PlaceMark(0);
        }

        private void btn_col2_Click(object sender, EventArgs e)
        {
            // place a mark at column index 1
            board.PlaceMark(1);
        }

        private void btn_col3_Click(object sender, EventArgs e)
        {
            // place a mark at column index 2
            board.PlaceMark(2);
        }

        private void btn_col4_Click(object sender, EventArgs e)
        {
            // place a mark at column index 3
            board.PlaceMark(3);
        }

        private void btn_col5_Click(object sender, EventArgs e)
        {
            // place a mark at column index 4
            board.PlaceMark(4);
        }

        private void btn_col6_Click(object sender, EventArgs e)
        {
            // place a mark at column index 5
            board.PlaceMark(5);
        }

        private void btn_col7_Click(object sender, EventArgs e)
        {
            // place a mark at column index 6
            board.PlaceMark(6);
        }

        public void GameWon()
        {
            // Get the winner
            string Winner = board.GetWinner();

            // Write the winner to the console
            Console.WriteLine("Player {0} won the game.", Winner);

            // Send players a system message showing who won
            MessageBox.Show("Congratualations " + Winner + "! You won the game.", "Game Finished");

            // Update current player label text and center it
            CurrentPlayerLabel.Text = Winner + " won the game!";
            CurrentPlayerLabel.Location = new Point((Width - CurrentPlayerLabel.Width) / 2, CurrentPlayerLabel.Location.Y);

            // Disable buttons
            btn_col1.Enabled = false;
            btn_col2.Enabled = false;
            btn_col3.Enabled = false;
            btn_col4.Enabled = false;
            btn_col5.Enabled = false;
            btn_col6.Enabled = false;
            btn_col7.Enabled = false;
        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            // Reset the board
            board.ResetBoard();

            // Refresh to update the board UI
            Refresh();

            // Enable all buttons
            btn_col1.Enabled = true;
            btn_col2.Enabled = true;
            btn_col3.Enabled = true;
            btn_col4.Enabled = true;
            btn_col5.Enabled = true;
            btn_col6.Enabled = true;
            btn_col7.Enabled = true;

            // Start the new game
            board.StartGame();
        }

        public void DisableColumn(int Column)
        {
            // Disable the given column's button
            Controls["btn_col" + Column].Enabled = false;
        }

        private void QuitGameMenuItem_Click(object sender, EventArgs e)
        {
            // Ask the user if they really want to quit
            DialogResult Dialog = MessageBox.Show("Are you sure you want to quit?", "Quit Confirmation", MessageBoxButtons.YesNo);

            if (Dialog == DialogResult.Yes)
                Dispose();
        }

        private void ChangeStarterMenuItem_Click(object sender, EventArgs e)
        {
            // Change menu text and show confirmation message
            ChangeStarterMenuItem.Text = "Change Starter to: " + board.ChangeStarter();
            MessageBox.Show("Change will take affect next game.", "Starter Color Changed");
        }

        public void UpdateTurnLabel(string Player)
        {
            // Update the current player text
            CurrentPlayerLabel.Text = "Current Player: " + Player + " (" + board.GetCurrentPlayerString() + ")";

            // Center the current player label
            CurrentPlayerLabel.Location = new Point((Width - CurrentPlayerLabel.Width) / 2, CurrentPlayerLabel.Location.Y);
        }
    }
}
