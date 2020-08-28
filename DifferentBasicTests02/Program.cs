using System;

namespace DifferentBasicTests02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you like to see multiplied: ");
            int numbr1 = Convert.ToInt32(Console.ReadLine());
            int x = 11;

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("\n"+numbr1 + " x " + i + " = " + (numbr1*i));
            }
        }
    }
}
