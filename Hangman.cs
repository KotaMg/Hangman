using System;
using System.Collections.Generic;
using System.IO;

/*
Name: Dakota McGregor
Date: 04/17/2021

This class will read the data in the text file and add it to the _words dictionary and send a random word to the allows class
*/

namespace Game
{
    public class Hangman
    {
        private Random _random = new Random();
        private Dictionary<string, string> _words;
        private List<string> _keyList;
        private List<string> _valueList;

        public Hangman()
        {
            UI.Theme();
            load();
        }

        private void load()
        {
            // send the data from a text file to the dictionary
            _words = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader("../../../textFiles/definitions.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(':');
                    _words.Add(data[0], data[1]);
                }
            }
            //sets a random num and sends the appropriate data to the gallows class
            int x = _random.Next(_words.Count);

            _keyList = new List<string>(_words.Keys);
            _valueList = new List<string>(_words.Values);

            Gallows gallows = new Gallows(_keyList[x],_valueList[x]);
        }
    }
}
