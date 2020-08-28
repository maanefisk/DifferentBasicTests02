using System;

namespace DifferentBasicTests02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test2
            Console.Write("\n First number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Third number: ");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Fourth number: ");
            int fourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "The average of " + first + " & " + second + " & " + third + " & " + fourth + " = " +
                              ((first + second + third + fourth)/4) + "\n");

            //Test1
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
