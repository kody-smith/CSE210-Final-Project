using System;
using System.Collections.Generic;
using System.Text;

namespace _05_jumper
{
    class Display
    {
        public int life = 4;
        public List<string> parachute = new List<string>();
        public List<char> chosenWord = new List<char>();
        // public char letter;
        // public string dashes;
        public bool wordChoice;
        // These three values are to test the new function "AddLetter":
        public string dashes = "---";
        public string word = "the";
        public string letter = "h";
        
        
        

        ///<summary>
        // in this function Removelife
        // the number of life will be reduced if the user input
        // did not matched with generated words.
        ///</summary>
       public int RemoveLife()
       {
            life--;
            Console.WriteLine(life);
            return life;
       }
       public List<string> CreateParachute()
       {
           parachute.Add("  ___ ");
           parachute.Add(@" /___\");
           parachute.Add(@" \   / ");
           parachute.Add(@"  \ /");
           parachute.Add("   0  ");
           parachute.Add(@"  /|\  ");
           parachute.Add(@"  / \ ");
           parachute.Add("     ");
           parachute.Add("     ");
           parachute.Add("^^^^^^^");


           return parachute;
       }

       public void printParachute()
       {
           for(int i = 0; i < parachute.Count; i++)
           {
               Console.WriteLine(parachute[i]);
           } 
       }

       public List<string> changeParachute()
       {
        //    CreateParachute();
           if (life == 4)
           {
               return parachute;
           }
           else if(life == 3)
           {
               parachute[0] = "     ";
               return parachute;
           }
           else if(life == 2)
           {   
               parachute[0] = "     ";
               parachute[1] = "     ";
               return parachute;
           }
           else if(life == 1)
           {
               parachute[0] = "     ";
               parachute[1] = "     ";
               parachute[2] = "     ";
               return parachute;
           }
           else
           {
               parachute[0] = "     ";
               parachute[1] = "     ";
               parachute[2] = "     ";
               parachute[3] = "     ";
               parachute[4] = "  x  ";
               return parachute;
           }
           
       }
    }
}

       ///<summary>
       //AddLetter is responsible for swaping the dash for the letter 
       //in the correct location if guessed correctly
       ///</summary>
    //    public string AddLetter(string dashes, char letter)
    //    {
    //        foreach (char dash in dashes)
    //        {
    //            Console.WriteLine(dashes.Replace(dash, letter));
    //        }
    //        return dashes;
    //    }
    
    //Here is the new function: