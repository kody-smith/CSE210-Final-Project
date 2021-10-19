using System;

namespace _06_mastermind
{
    class Hint
    {
        private Code Code = new Code();

        public void GenerateHint()
        {
            string HintStart = Code.GenerateCode();
        }
    }
}