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
            string hintStart = Code.GenerateCode();
        }
        // if exact then place "x". If correct, but not right spot, place "o". If totally wrong, place "*".


        /// <summary>
        /// The ProcessHint() function throws out a hint for the current guess to the code.
        /// It does this through using one Stringbuilder Variable, 
        private void ProcessHint(string originalCode, string guessedCode)
        {
            StringBuilder sb = new StringBuilder();
            List<string> guessedWord = new List<string>();
            List<string> actualCode = new List<string>();
            List<string> hint = new List<string>();
            foreach(char letter in guessedCode)
            {
                guessedWord.Add(letter.ToString());
            }
            foreach(char letter in originalCode)
            {
                actualCode.Add(letter.ToString());
            }
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
            for (int a = 0; a <= 4; a++)
            {
                sb.Append(hint[a]);
            }
            // return sb.ToString();
        }
    }
}