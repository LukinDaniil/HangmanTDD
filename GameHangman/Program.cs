using System;

namespace GameHangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to game Hangman!");
            Console.WriteLine("Input word for guessing: ");
            //считываем слово для отгадывания
            string hiddenWord = Console.ReadLine();
            //инициализируем объект игры с этим словом в виде загаданного
            Hangman hangman = new Hangman(hiddenWord);
            //просим ввести число попыток
            Console.WriteLine("Input amount of attempts: ");
            int amountOfAttempts;
            while (!int.TryParse(Console.ReadLine(), out amountOfAttempts) || amountOfAttempts <= 0)
            {
                Console.Write("Input positive number: ");
            }
            hangman.setRemainingAttempts(amountOfAttempts);
            //игра идёт пока игра не будет выиграна, либо пока количество попыток не достигнет 0
            while (!hangman.gameWon() && hangman.remainingAttempts != 0)
            {
                Console.Write("Input letter: ");
                char guessLetter;
                while (!char.TryParse(Console.ReadLine(), out guessLetter) || !char.IsLetter(guessLetter))
                {
                    Console.Write("Input one letter: ");
                }
                hangman.guess(guessLetter);
                Console.WriteLine($"Current state of guessing: {hangman.currentGameState}");
            }
            //в зависимости от результата игры выводим сообщение
            if (hangman.gameWon())
            {
                Console.WriteLine($"You won. Guessed word is: {hiddenWord}");
            }
            else
            {
                Console.WriteLine($"You lost. Guessed word is: {hiddenWord}");
            }
        }
    }
}
