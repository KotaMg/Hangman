using System;

/*
Name: Dakota McGregor
Date: 04/17/2021

While loop to keep calling a new instance of hangman as long as the user keeps wanting to play, when keepPlaying = false, the game ends.
*/

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            while (keepPlaying)
            {
                Console.Clear();
                Hangman hangman = new Hangman();
                keepPlaying = Validation.BoolValidation("\r\nKeep playing? (yes/no)");

            }

        }
    }
}
