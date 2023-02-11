using System;
namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1,100);
            int guess;
            do{
                Console.WriteLine("Guess the number between 1 and 100");
                guess = int.Parse(Console.ReadLine());
                if(guess < numberToGuess){
                    Console.WriteLine("Number is greater");
                } else if ( guess > numberToGuess){
                    Console.WriteLine("Number is lower");
                }
            } while (guess != numberToGuess);
                Console.WriteLine("You nail it!😊");
            
        }
    }
}
