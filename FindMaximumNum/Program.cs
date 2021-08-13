using System;

namespace FindMaximumNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maximum Number Program ! ");

            Console.WriteLine(" Maximum Number is:-");
            int MaxNumber = Check.MaximumInteger(11, 22, 33);
            Console.WriteLine(MaxNumber);

            float MaxNumber1 = Check.MaximumFloat(11.2f,45.2f,45.63f);
            Console.WriteLine(MaxNumber1);

            string MaxNumber2 = Check.MaximumString("42.2","45.12","45.25");
            Console.WriteLine(MaxNumber2);
        }
    }
}
