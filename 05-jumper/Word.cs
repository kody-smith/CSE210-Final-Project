using System;
using System.Text;
using System.Collections.Generic;
namespace _05_jumper
{
    class Word
    {
        //public List<string> _dashes = new List<string>();
        public string dashes;
        public Director director;
        public string chosenWord;
        public bool letterexists = false;
        public string[] _wordArray = {"empyrean", "arapaima", "guiana", "burrito", "cheese", "queso", "montana", "idaho", "missouri", "florida", "president", "organization", "topaz", "supercalifragilisticexpialidocious", "pound",
                            "water", "jersey", "jabberwocky", "persona", "allegory", "reverence", "temple","subtle","demagogue","transient","arid","desert","pizza","intrepid",
                            "extraterrestrial","antidote","beach","agriculture","paradise","armistice","accordion","saxophone","piano","enterprise","sovereignty","amendment",
                            "lincoln","mercury","sepulchral","nyctophobia","solomon","revelation"};
        Random rnd = new Random();
        ///<summary>
        /// ChooseWord() chooses a random word from a list of -currently- 40 different words.
        /// It creates a random integer value between 0 to 40 and will give that specific string into the output string _chosenWord.
        ///<summary>
        public void ChooseWord()
       {
           int wordchoice = rnd.Next(0,_wordArray.Length);
           chosenWord = _wordArray[wordchoice];

           StringBuilder sb = new StringBuilder();
           for (int i = 0; i < chosenWord.Length; i++){
               sb.Append("_");
           }
           dashes = sb.ToString();
       }

       ///<summary>
       //DisplayWord will check the count of the random word
       //and print dashed lines to show the user how many letters
       //are in the word
       ///</summary>
       public void DisplayWord()
       {
           Console.WriteLine(dashes);
       }
       
       ///<summary>
       /// AddLetter is responsible for swaping the dash for the letter 
       /// in the correct location if guessed correctly.
       ///
       /// When this is done, it will return true if the letter
       /// existed and false if it did not exist in the word.
       ///</summary>
       public bool AddLetter(char guessChar, string guessString)
       {
           letterexists = false;
           StringBuilder sb = new StringBuilder(dashes);

           for (int i=0;i < chosenWord.Length;i++)
            {
               char letter = chosenWord[i];
               if (guessChar == letter) 
                {
                    letterexists = true;
                    sb[i] = guessChar;
                }
            }   

            dashes = sb.ToString();

            return letterexists;
        }
        public bool KeepContinue()
        {
            if(chosenWord == dashes)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

      
    }
}
