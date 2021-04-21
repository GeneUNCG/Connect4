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
                // Disable text box now that user has entered his data
                UserInputTextBox.Enabled = false;

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

        private void UserInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserInputTextBox.Enabled)
            {
                // User is attempting to close this window without having input

                DialogResult Result = MessageBox.Show("You must enter a name, otherwise you will not be able to play and the application will exist. Are you sure you want to close?", "Must Enter a Name", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    // User insists on not entering a name, exit the entire application
                    Application.Exit();
                }

            }
        }
    }
}
