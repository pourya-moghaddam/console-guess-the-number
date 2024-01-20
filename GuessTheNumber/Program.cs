using System;

namespace GuessTheNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("In what range of numbers do want to play? (1 to ?) ");
            int max = Convert.ToInt32(Console.ReadLine());
            int secretNumber = random.Next(1, max + 1);
            int numberGuessed = 0;
            Console.WriteLine("Random num: {0}", secretNumber);

            do
            {
                Console.WriteLine("Enter a Number between 1 & {0}", max);
                numberGuessed = Convert.ToInt32(Console.ReadLine());

                if (numberGuessed < secretNumber)
                    Console.WriteLine("It's higher!");
                else if (numberGuessed > secretNumber)
                    Console.WriteLine("It's lower!");

            } while (numberGuessed != secretNumber);

            Console.WriteLine("You guessed it. It was {0}!", secretNumber);
        }
    }
}
