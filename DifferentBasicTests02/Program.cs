﻿using System;

namespace DifferentBasicTests02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test11
            Console.WriteLine("What is your age?");
            int userage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are "+ userage +"years young \n");

            //Test10
            Console.Write("\n First number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Second number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Produces: " + ((x + y) * z) + " & " + (x*y + y*z));

            //Test9
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

            //Test8 from https://www.w3resource.com/csharp-exercises/basic/index.php
            Console.WriteLine("Enter a number you like to see multiplied: ");
            int numbr1 = Convert.ToInt32(Console.ReadLine());
            int l = 11;

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine("\n"+numbr1 + " x " + i + " = " + (numbr1*i));
            }
        }
    }
}
