using System;

namespace SelectionStatementsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numer guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);


            var random = new Random();
            var number = random.Next(1, upperLimit);


            Console.WriteLine("Input your guess");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high! Sorry.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry.");
            }
            else if (guess == number)
            {
                Console.WriteLine("You are correct!! ");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }


            // Switch Statement

            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is great!");
                    break;

                case "science":
                    Console.WriteLine("Science is great! ");
                    break;

                case "english":
                    Console.WriteLine("English me favorite too");
                    break;

                case "history":
                    Console.WriteLine("History is very important.");
                    break;

                case "fine Arts":
                    Console.WriteLine("What a cool subject!");
                    break;




                default:
                    Console.WriteLine($"Never heard of {subject} before?!?!");
                    break;





            }




        }
    }
}

