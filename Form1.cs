using System;
using System.Linq;
using System.Windows.Forms;

namespace Hang
{
    public partial class Form1 : Form
    {
        private string word = "welcome";
        private char[] guessedLetters;
        private int mistakeCount = 0;
        private readonly string[] hangmanImages = {
            @"C:\Users\AK\source\repos\Hang\hang\hang_6.bmp",
            @"C:\Users\AK\source\repos\Hang\hang\hang_5.bmp",
            @"C:\Users\AK\source\repos\Hang\hang\hang_4.bmp",
            @"C:\Users\AK\source\repos\Hang\hang\hang_3.bmp",
            @"C:\Users\AK\source\repos\Hang\hang\hang_2.bmp",
            @"C:\Users\AK\source\repos\Hang\hang\hang_1.bmp",
            @"C:\Users\AK\source\repos\Hang\hang\hang_0.bmp"
        };

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            guessedLetters = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                guessedLetters[i] = '_'; // Initialize guessed letters with underscores
            }
            mistakeCount = 0; // Reset mistake count
            AddImage(hangmanImages[mistakeCount]); // Initial image
            UpdateGuessedWordLabel(); // Update word display
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // You can implement any additional logic you want when the picture box is clicked
        }

        private bool IsWordGuessed()
        {
            return !guessedLetters.Contains('_');
        }

        private void ProcessGuess(char guess)
        {
            bool found = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == guess && guessedLetters[i] == '_')
                {
                    guessedLetters[i] = guess;
                    found = true;
                }
            }

            if (!found)
            {
                mistakeCount++;
                if (mistakeCount == hangmanImages.Length)
                {
                    MessageBox.Show("Game Over! The word was: " + word);
                    InitializeGame(); // Optionally, reset the game
                }
                else
                {
                    AddImage(hangmanImages[mistakeCount]); // Update image
                }
            }
            else if (IsWordGuessed())
            {
                MessageBox.Show("Congratulations! You've guessed the word: " + word);
                InitializeGame(); // Optionally, reset the game
            }

            UpdateGuessedWordLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implement the logic for button1 click if necessary
        }

        private void AddImage(string imagePath)
        {
            try
            {
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image file not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGuessedWordLabel()
        {
            label1.Text = string.Join(" ", guessedLetters);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.Text.Length > 0)
            {
                char guess = textBox.Text.ToLower()[0];

                if (char.IsLetter(guess))
                {
                    ProcessGuess(guess);
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a single letter.");
                }

                textBox.Clear();
            }
        }
    }
}
