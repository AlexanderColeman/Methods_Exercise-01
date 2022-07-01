using System;

namespace Methods_Exercise_01_Answers
{

    class Program
    {
        static void Main(string[] args)
        {

            PrintGreeting();

            AddSpace();

            SayHello("John", "Smith");

            AddSpace();

            GreetUser();

            AddSpace();

            Exponentiate();

            AddSpace();

            IsPrime();
        }

        // TODO: Create a public static method called AddSpaces() which creates 2 blank lines when called
        // and does NOT **return** anything

        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine();

        }

        // TODO: Create a public static method called PrintGreeting() with a return type of void that takes no parameters,
        // and writes to the console "Hello World!"

        public static void PrintGreeting()
        {
            Console.WriteLine("Hello World!");
        }


        // TODO: Create a public static method called SayHello() with a return type of void which takes 2 parameters firstName & lastName,
        // and concatenates them into a sentence Ex: "Hello, John Smith!" then writes them to the console

        public static void SayHello(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}");

        }



        // TODO: Create a method called GreetUser() that asks the user for their name
        // then greets them with that name to the console (don't forget to prompt the user to enter their name!)

        public static void GreetUser()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        // TODO: Create a method called Exponentiate() that asks the user for a number and a powerOF
        // and then calculates the result of raising the first to the second (don't forget to prompt the user to enter the 2 numbers!)
        public static void Exponentiate()
        {
            int sum = 0;
            int x = 0;
            int y = 0;
            while (true)
            {
                Console.WriteLine("Please enter two numbers");
               x = Convert.ToInt32(Console.ReadLine());
               y = Convert.ToInt32(Console.ReadLine());

                sum = (int)Math.Pow(x, y);

                if(sum >= int.MaxValue || sum <= int.MinValue)
                {
                    Console.WriteLine("Those numbers were to big please enter smaller numbers");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{x} to the powerOf {y} is: {sum}");
        }


        // TODO: Create a method called IsPrime() that asks the user for a number then returns true if the number is prime or false otherwise
        // (don't forget to prompt the user to enter the number!)

        public static void IsPrime()
        {
            Console.WriteLine("Enter a number to see if it is prime");
            int x = Convert.ToInt32(Console.ReadLine());
            bool isPrime = false;
            string factors = "";

            for (int i = x-1; i > 1; i--)
            {
                if (x % i == 0)
                {
                    
                    isPrime = false;
                    break;
                    
                }
                else
                {
                   
                    isPrime = true;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{x} is prime");
            }
            else
            {
                Console.WriteLine($"{x} is not prime");
                
            }

        }
    }
}
