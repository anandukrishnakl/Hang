# Hangman Game (Windows Forms Application)

## Description
A simple Hangman game in C# using Windows Forms. The player guesses letters to reveal a hidden word. Incorrect guesses display Hangman images. The game ends when the word is guessed or the max mistakes are reached.

## Features
- Displays Hangman images for incorrect guesses.
- Updates the guessed word dynamically.
- Shows game-over messages for win/loss.
- Resets automatically after each game.

## Installation & Usage
1. Open the project in Visual Studio.
2. Ensure image files (`hang_0.bmp` to `hang_6.bmp`) exist at `C:\Users\AK\source\repos\Hang\hang\` or update paths.
3. Build and run the application.
4. Enter letters to guess the word.

## Code Explanation
- **Form1 Constructor**: Initializes the game.
- **InitializeGame()**: Resets state and sets images.
- **ProcessGuess(char guess)**: Handles letter input.
- **IsWordGuessed()**: Checks if the word is guessed.
- **AddImage(string imagePath)**: Updates the Hangman image.
- **UpdateGuessedWordLabel()**: Displays guessed letters.
- **textBox1_TextChanged()**: Captures user input.

## Dependencies
- .NET Framework
- Windows Forms (System.Windows.Forms)
- System.Drawing for image handling

## Future Improvements
- Allow different words.
- Add a graphical keyboard.
- Implement scoring.
- Provide difficulty levels.

## License
This project is open-source and free to use and modify.

