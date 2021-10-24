using System;
using System.Collections.Generic;
using System.Text;

namespace _06_mastermind
{
    class Code
    {
        private string _code;

        public void GenerateCode()
        {
            Random rnd = new Random();
            int code = rnd.Next(1000,10000);
            string newcode = code.ToString();
            // Console.WriteLine(newcode);
            _code = newcode;
        }

        public string GetCode()
        {
            return _code;
        }

        public string GenerateHint()
        {
            StringBuilder sb = new StringBuilder();
            string x;
            foreach (char i in _code)
            {
                sb.Append('*');
            }
            x = sb.ToString();
            return x;
        }
        
        public string ProcessHint(string guessedCode)
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
            foreach(char letter in _code)
            {
                actualCode.Add(letter.ToString());
            }
            foreach (char letter in _code)
            {
                hint.Add("*");
            }

            // The for loop in a for loop is to check for potential numbers that are generally guessed correctly ("o") and then if a number was exactly correct ("x").
            for (int u = 0; u <= 3; u++)
            {
                if( u == 0)
                {
                    for (int i = 0; i <= 3; i++)
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
                else
                {
                    for (int i = 0; i <= 3; i++)
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
            }

            // this for loop is to build the hint within the StringBuilder
            for (int a = 0; a <= 3; a++)
            {
                sb.Append(hint[a]);
            }
            // after the for loop return the Stringbuilder that's converted into a string using the .ToString() function.

            return sb.ToString();
        }
    }
}