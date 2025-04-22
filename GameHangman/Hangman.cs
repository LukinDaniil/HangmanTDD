using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHangman
{
    public class Hangman
    {
        public string hiddenWord;

        public Hangman()
        {
        }

        public Hangman(string wordForGuessing)
        {
            this.hiddenWord = wordForGuessing;
        }
    }
}
