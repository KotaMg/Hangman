using System;
using System.Collections.Generic;


/*
Name: Dakota McGregor
Date: 04/17/2021

This class is where the core gameplay logic is located.
Adds correct user guesses to the _guesses list and incorrect guesses to the _misses list.
Will display a _ if _guesses does not contain a char in _word, if a char is in both _guesses and _word, it will display that char.
WinnerCheck() is called everytime after user inputs a char to display when the game is over.

*/

namespace Game
{
    public class Gallows
    {
        private string _word;
        private string _definition;
        private List<char> _guesses = new List<char>();
        private List<char> _misses = new List<char>();

        public Gallows(string word, string definition)
        {
            _word = word.ToUpper();
            _definition = definition;
            Play();
        }


        private void Play()
        {
            bool win = false; 

            while (!win && _misses.Count < 6)
            {
                Console.Clear();
                Display();
                char usersGuess = Validation.CharValidation("\r\nPlease guess a letter: ");

                if (_word.Contains(usersGuess))
                {
                    if (_guesses.Contains(usersGuess))
                    {
                        continue;
                    }
                    _guesses.Add(usersGuess);
                }
                else
                {
                    _misses.Add(usersGuess);
                }

                win = WinnerCheck();
            }
        }


        private void Display()
        {
            Console.Clear();

            UI.Header("Hangman");
            Console.WriteLine($"Hint: {_definition} ({_word}) \r\n\r\n"); // remove "({_word}) when ready to play the game"
            UI.Separator();
            foreach (Char c in _word)
            {
                if (_guesses.Contains(c))
                {
                    Console.Write($"{c} ");
                }   
                else
                {
                    Console.Write('_');
                    Console.Write(' ');
                }
            }
            Console.WriteLine("\r\n");
            UI.Separator();

            Console.Write("\r\nUsed letters: ");
            foreach (char c in _misses)
            {
                Console.Write($"{c},");
            }

            Console.WriteLine("\r\n\r\n");
            UI.Footer("");
        }


        private bool WinnerCheck()
        {
            bool win = true;

            foreach(Char letter in _word)
            {
                if (!_guesses.Contains(letter))
                {
                    win = false;
                }
            }

            if (win)
            {
                Console.Clear();
                UI.Header("WINNER!");

                Console.WriteLine($"\r\nYou guessed it! {_word} was the correct answer!\r\n");
                UI.Separator();
            }
            else
            {
                Console.Clear();
                UI.Header("Game Over");
                Console.WriteLine($"\r\nThe correct answer was: {_word}");
            }

            return win;
        }
    }
}
