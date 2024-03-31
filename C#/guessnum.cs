using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 101);
        int attempts = 0;
        
        Console.WriteLine("Welcome to the Random Number Game!");
        Console.WriteLine("Find the number between 1 and 100.");
        
        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            
            attempts++;
			
			int guess = Int32.Parse(input);
			
            if (guess == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the number in " + attempts.ToString() + " attempts.");
                break;
            }
			else if (guess < randomNumber)
            {
                Console.WriteLine("Too low!");
            }
			else
            {
                Console.WriteLine("Too high!");
            }
        }
        
        Console.WriteLine("Thanks for playing!");
    }
}