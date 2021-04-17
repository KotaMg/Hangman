using System;
using System.Collections.Generic;
using System.Text;


/*
Name: Dakota McGregor
Date: 04/17/2021

This class is setup to validate user input based on the type of data the user will input
*/

namespace Game
{
    public static class Validation
    {
        public static bool BoolValidation(string message)
        {
            Console.WriteLine($"{message}");

            string z = Console.ReadLine();

            while (z.ToLower() != "yes" && z.ToLower() != "no")

            {
                Console.WriteLine("\r\nError: Please only type \"Yes\" or \"No\"\r\n");
                Console.Write($"{message}");
                z = Console.ReadLine();
            }

            return (z == "yes");
        }


        public static string StringValidation(string y)
        {
            Console.WriteLine(y);
            string x = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(x))
            {
                Console.WriteLine("\r\nERROR: Please do not leave blank\r\n");
                Console.Write("Please re-enter your answer: ");
                x = Console.ReadLine();
            }

            return x.ToUpper(); ;
        }

        public static char CharValidation(string y)
        {
            Console.WriteLine(y);
            string x = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(x))
            {
                Console.Write("ERROR: Please re enter your answer: ");
                x = Console.ReadLine();
            }
            char z = x.ToUpper()[0];

            return z;
        }

        public static int IntergerValidation(string message)
        {
            Console.WriteLine(message);

            string i = Console.ReadLine();
            int z;

            while (!(int.TryParse(i, out z)))
            {
                Console.WriteLine("\r\nERROR: Please only enter a valid number.\r\n");
                Console.Write("Please re-enter your answer: ");
                i = Console.ReadLine();
            }
            return z;
        }

        public static int RangeValidation(string y, int min, int max)
        {
            Console.WriteLine(y);

            string z = Console.ReadLine();
            int i;
            while (!(int.TryParse(z, out i)) || i < min || i > max)
            {

                Console.Write("\r\nERROR: Please re-enter your answer: ");
                z = Console.ReadLine();

            }
            return i;
        }

        public static double DoubleValidation(string message)
        {
            Console.Write($"{message}");

            string z = Console.ReadLine();
            double number;
            while (!(double.TryParse(z, out number)))
            {
                Console.WriteLine("Oops! That doesnt apper to be a vaid answer.\r\n");
                Console.Write($"Please re enter your answer: ");

                z = Console.ReadLine();
            }
            return number;
        }
    }
}
