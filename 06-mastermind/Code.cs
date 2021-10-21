using System;
using System.Collections.Generic;
using System.Text;

namespace _06_mastermind
{
    class Code
    {
        private string code;

        public string GenerateCode()
        {
            Random rnd = new Random();
            int codeInt = rnd.Next(1000,10000);
            string newcode = codeInt.ToString();
            Console.WriteLine(newcode);
            code = newcode;
            return code;
        }

        public string GetCode()
        {
            return code;
        }

        public string GenerateHint()
        {
            StringBuilder sb = new StringBuilder();
            string x;
            foreach (char i in code)
            {
                sb.Append('*');
            }
            x = sb.ToString();
            return x;
        }
    }
}