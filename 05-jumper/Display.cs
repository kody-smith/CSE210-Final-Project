using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Display
    {
        public int life = 4;
        public List<string> _Parachute = new List<string>();
        public List<char> _chosenWord = new List<char>();
        public char letter;
        public string dashes;
        public bool _wordChoice;
        

        ///<summary>
        // in this function Removelife
        // the number of life will be reduced if the user input
        // did not matched with generated words.
        ///</summary>
       public int RemoveLife(bool _wordChoice)
       {
           if (!_wordChoice)
           {
               life--;
           }
           return life;
       }
       public List<string> CreateParachute()
       {
           _Parachute.Add("  ___ ");
           _Parachute.Add(@" /___\");
           _Parachute.Add(@" \   / ");
           _Parachute.Add(@"  \ /");
           _Parachute.Add("   0  ");
           _Parachute.Add(@"  /|\  ");
           _Parachute.Add(@"  / \ ");
           _Parachute.Add("     ");
           _Parachute.Add("     ");
           _Parachute.Add("^^^^^^^");


           return _Parachute;
       }

       public void printParachute()
       {
           for(int i = 0; i < _Parachute.Count; i++)
           {
               Console.WriteLine(_Parachute[i]);
           } 
       }

       public List<string> changeParachute()
       {
           if (life == 4)
           {
               return _Parachute;
           }
           else if(life == 3)
           {
               _Parachute[0] = "     ";
           }
           else if(life == 2)
           {
               _Parachute[1] = "     ";
           }
           else if(life == 1)
           {
               _Parachute[2] = "     ";
           }
           else
           {
               _Parachute[3] = "     ";
               _Parachute[4] = "  x  ";
           }
           return _Parachute;
       }
       ///<summary>
       //DisplayWord will check the count of the random word
       //and print dashed lines to show the user how many letters
       //are in the word
       ///</summary>
       public string DisplayWord(string dashes)
       {
           dashes = "";
           foreach (char letter in _chosenWord)
           {
               Console.Write('_');
               dashes = Console.ReadLine();
               string dash = letter.ToString();
           }
           return dashes;
       }
       ///<summary>
       //AddLetter is responsible for swaping the dash for the letter 
       //in the correct location if guessed correctly
       ///</summary>
       public string AddLetter(string dashes, char letter)
       {
           foreach (char dash in dashes)
           {
               Console.WriteLine(dashes.Replace(dash, letter));
           }
           return dashes;
       }
    }
}