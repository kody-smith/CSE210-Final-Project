using System;
using System.Collections.Generic;
using System.Text;

namespace _06_mastermind
{
    class Code
    {
        private string _code = "";

        public string GenerateCode()
        {
            Random rnd = new Random();
            int code = rnd.Next(1000,10000);
            string newcode = code.ToString();
            return newcode;
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
    }
}