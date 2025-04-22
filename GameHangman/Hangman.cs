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
        public string currentGameState;
        public Hangman()
        {
        }

        public Hangman(string wordForGuessing)
        {
            this.hiddenWord = wordForGuessing;
            currentGameState = "";
            for (int i = 0; i < hiddenWord.Length; i ++)
            {
                currentGameState += "_";
            }
        }

        public void setRemainingAttempts(int newRemainingAttempts)
        {
            this.remainingAttempts = newRemainingAttempts;
        }

        public string checkCurrentGameState()
        {
            string stateOfGuessing = currentGameState;
            return stateOfGuessing;
        }

        public void guess(char guessLetter)
        {
            if(hiddenWord.Contains(guessLetter))
            { 
                for (int i = 0; i < hiddenWord.Length; i ++)
                {
                    if (hiddenWord[i] == guessLetter)
                    {
                        char[] currentStateArray = currentGameState.ToCharArray();
                        currentStateArray[i] = guessLetter;
                        currentGameState = new string(currentStateArray);
                    }
                }
            }
            else
            {
                setRemainingAttempts(remainingAttempts - 1);
            } 
        }

        public bool gameWon()
        {
            return currentGameState == hiddenWord;  
        }
    }
}
