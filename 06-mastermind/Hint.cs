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

        private void ProcessHint(string originalCode, string guessedCode)
        {
            StringBuilder sb = new StringBuilder();
            List<string> wordList = new List<string>();
            List<string> actualCode = new List<string>();
            List<string> hint = new List<string>();
            foreach(char letter in guessedCode)
            {
                wordList.Add(letter.ToString());
            }
            foreach(char letter in originalCode)
            {
                actualCode.Add(letter.ToString());
            }
            for (int u = 0; u <= 4; u++)
            {
                for (int i = 0; i <= 4; i++)
                {
                    // if()
                    // {

                    // }
                }
                if (wordList[u] == actualCode[u])
                {
                    hint[u] = "x";
                }
            }
            /*
            int u = 0;
            
            
            foreach (char letter in codeToCompare)
            {
                wordList.Add(letter.ToString());
            }
            
            foreach(char letter in codeToCompare)
            {
                if (letter = wordList[u])
                {

                }
            }*/
        }
    }
}