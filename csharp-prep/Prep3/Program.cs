using System;

class Program
{
    static void Main(string[] args)
    {
        
        // string inputguess = "";
        // Guess My Number game
        int tallyGuesses = 0;
        int guess = 0;

        Console.WriteLine("Welcome to the Guess My Number game!");

        Console.WriteLine("What is the magic number?: ");
        string magicString = Console.ReadLine();
        int magicNumber = int.Parse(magicString);
        List<int> listOfNumbers = new List<int>();

    
        while (magicNumber != guess)
        {
            Console.WriteLine("What is your guess?: ");
            string inputguess = Console.ReadLine();
            guess = int.Parse(inputguess);

            listOfNumbers.Add(guess);
            tallyGuesses++;


            if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"You guessed the magic number {magicNumber} in {tallyGuesses} guesses!");

    }
}