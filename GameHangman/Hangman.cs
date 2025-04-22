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
        public int remainingAttempts;
        public Hangman()
        {
        }

        public Hangman(string wordForGuessing)
        {
            this.hiddenWord = wordForGuessing;
        }

        public void setRemainingAttempts(int newRemainingAttempts)
        {
            this.remainingAttempts = newRemainingAttempts;
        }

        public string checkCurrentGameState()
        {
            //todo реализовать установку stateOfGuessing согласно загаданному слову
            string stateOfGuessing = "____";
            return stateOfGuessing;
        }
    }
}
