using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        bool run = false;
        string con;
        while (!run)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 2);
            Console.WriteLine("Guess a number between 1 and 50");
            guess = int.Parse(Console.ReadLine());
            if (guess >= num )
            {
                Console.WriteLine("Number is too high");
            }
            else if (guess <= num) 
            { 
                Console.WriteLine("Number is too low");
            }
           
            if (guess == num)
            {
                Console.WriteLine("Correct number");
                Console.WriteLine("Would you like to continue y/n");
                con = Console.ReadLine().ToLower();
            }
          
            if (con == "n")
            {
                run = true;
            }

        }
    }
}   