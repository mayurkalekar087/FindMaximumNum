using System;

namespace FindMaximumNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Number Program");

            Console.WriteLine(" Maximum Number is :-");
            int MaxNumber = Check.MaximumInteger(11, 22, 33);
            Console.WriteLine(MaxNumber);
        }
    }
}
