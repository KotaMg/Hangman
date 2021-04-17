using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/*
Name: Dakota McGregor
Date: 04/17/2021

UI class just for design/theme/"loading screen"
*/

namespace Game
{
    public static class UI
    {

        public static void Header(string y)
        {
            Console.WriteLine($"=========\r\n {y.ToUpper()}\r\n=========\r\n");
        }

        public static void Footer(string y, bool pause = false)
        {
            Console.Write($"=====================\r\n{y.ToUpper()}");
            if (pause) Console.ReadLine();
        }

        public static void Separator()
        {
            Console.WriteLine("---------------------");
        }

        public static void CGaming()
        {
            string logo = @"
   _______   _   _      _______  _______  _______ _________ _        _______ 
  (  ____ \ ( ) ( )    (  ____ \(  ___  )(       )\__   __/( (    /|(  ____ \
  | (    \/_| |_| |_   | (    \/| (   ) || () () |   ) (   |  \  ( || (    \/
  | |     (_   _   _)  | |      | (___) || || || |   | |   |   \ | || |      
  | |      _| (_) |_   | | ____ |  ___  || |(_)| |   | |   | (\ \) || | ____ 
  | |     (_   _   _)  | | \_  )| (   ) || |   | |   | |   | | \   || | \_  )
  | (____/\ | | | |    | (___) || )   ( || )   ( |___) (___| )  \  || (___) |
  (_______/ (_) (_)    (_______)|/     \||/     \|\_______/|/    )_)(_______)
                                                                             ";
            Console.WriteLine(logo);
            Thread.Sleep(1500);
            Console.WriteLine("");

        }

        public static void Loading()
        {
            Console.Write($"Loading");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(250);
            }
        }

        public static void Theme()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}


