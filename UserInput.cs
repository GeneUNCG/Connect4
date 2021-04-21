using System;
using System.Windows.Forms;

namespace Connect4
{
    public partial class UserInput : Form
    {
        private readonly Board Board;

        public UserInput(string Prompt, Board Board)
        {
            InitializeComponent();

            // Set Board
            this.Board = Board;

            // Update the window title
            Text = Prompt;

            // Update the question Label
            QuestionLabel.Text = Prompt;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void UserInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }

        private void Submit()
        {
            if (string.IsNullOrEmpty(UserInputTextBox.Text))
            {
                MessageBox.Show("Please fill out the text box.", "Textbox Empty");
            }
            else
            {
                if (QuestionLabel.Text.Contains("Red"))
                {
                    Board.SetRedName(UserInputTextBox.Text);
                }
                else
                {
                    Board.SetYellowName(UserInputTextBox.Text);
                }
                Dispose();
            }
        }
    }
}
