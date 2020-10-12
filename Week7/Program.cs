using System;

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What`s your gender (m/f)?");
            string userInput = Console.ReadLine();
            Hello(userInput);

        }
        public static void Hello(string gender)
        {
            if (gender == "f")
            {
                Console.WriteLine("Hello,madam!");
            }
            else if (gender == "m")
            {
                Console.WriteLine("Hello , sir!");
            }
            else
            {
                Console.WriteLine("Hello person");
            }
        }
}   }
