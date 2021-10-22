using System;
using System.Text;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Hint
    {
        // TODO: Put important variables right here
        private Code Code = new Code();
        public void GenerateHint()
        {
            // string hintStart = Code.GenerateCode();
            
            // string hintOutput = ProcessHint(hintStart, );
            // return
        }
        // if exact then place "x". If correct, but not right spot, place "o". If totally wrong, place "*".


        /// <summary>
        /// The ProcessHint() function throws out a hint for the current guess to the code.
        /// <summary>
        private void ProcessHint(string originalCode, string guessedCode)
        {
            StringBuilder sb = new StringBuilder();
            List<string> guessedWord = new List<string>();
            List<string> actualCode = new List<string>();
            List<string> hint = new List<string>();
            
            // the 2 foreach loops are made to build the lists for the generated code and the guessed code
            foreach(char letter in guessedCode)
            {
                guessedWord.Add(letter.ToString());
            }
            foreach(char letter in originalCode)
            {
                actualCode.Add(letter.ToString());
            }

            // The for loop in a for loop is to check for potential numbers that are generally guessed correctly ("o") and then if a number was exactly correct ("x").
            for (int u = 0; u <= 4; u++)
            {
                actualCode[u] = "*";
                for (int i = 0; i <= 4; i++)
                {
                    if(guessedWord[u] == actualCode[i])
                    {
                        hint[u] = "o";
                    }
                }
                if (guessedWord[u] == actualCode[u])
                {
                    hint[u] = "x";
                }
            }

            // this for loop is to build the hint within the StringBuilder
            for (int a = 0; a <= 4; a++)
            {
                sb.Append(hint[a]);
            }
            // after the for loop return the Stringbuilder that's converted into a string using the .ToString() function.

            // return sb.ToString();
        }
    }
}