using System;
using System.Text;
using System.Collections.Generic;
namespace _05_jumper
{
    class Word
    {
        //public List<string> _dashes = new List<string>();
        public string _dashes;
        public string _chosenWord;
        public string[] _wordArray = {"empyrean", "arapaima", "Guiana", "Burrito", "cheese", "queso", "Montana", "Idaho", "Missouri", "Florida", "President", "Organization", "topaz", "supercalifragilisticexpialidocious", "pound",
                            "water", "jersey", "jabberwocky", "persona", "allegory", "reverence", "temple","subtle","demagogue","transient","arid","desert","pizza","intrepid",
                            "Extraterrestrial","antidote","beach","agriculture","paradise","armistice","accordion","saxophone","piano","enterprise","Sovereignty","amendment",
                            "lincoln","mercury","sepulchral","nyctophobia","solomon","revelation"};
        Random rnd = new Random();
        ///<summary>
        /// ChooseWord() chooses a random word from a list of -currently- 40 different words.
        /// It creates a random integer value between 0 to 40 and will give that specific string into the output string _chosenWord.
        ///<summary>
        public void ChooseWord()
       {
           int wordchoice = rnd.Next(0,_wordArray.Length);
           Console.WriteLine(wordchoice);
           _chosenWord = _wordArray[wordchoice];
           Console.WriteLine(_chosenWord);

           StringBuilder sb = new StringBuilder();
           for (int i=0;i<_chosenWord.Length;i++){
               sb.Append("_");
           }
           _dashes = sb.ToString();
       }

       ///<summary>
       //DisplayWord will check the count of the random word
       //and print dashed lines to show the user how many letters
       //are in the word
       ///</summary>
       public void DisplayWord()
       {
           Console.WriteLine(_dashes);
       }
       
        ///<summary>
       // public datetype DisplayWord()
       // {
        //  foreach (char word in _choseWord)
        //      {
            //      List<string> Word = new List<string>();
        //          Word.Add(word);
        //          string dash 
        //}

       //}
       ///</summary>



       ///<summary>
       //AddLetter is responsible for swaping the dash for the letter 
       //in the correct location if guessed correctly
       ///</summary>
       public void AddLetter(char guessChar,string guessString)
       {
           StringBuilder sb = new StringBuilder(_dashes);
           for (int i=0;i < _chosenWord.Length;i++){
               char letter = _chosenWord[i];
               if (guessChar == letter) {
                   sb[i] = guessChar;
               }
           }
           _dashes = sb.ToString();
        }
       ///<summary>
       ///returns bool value.
       ///</summary>
    //    public void CompareWord()
    //    {
    //        if()
    //        {

    //        }
    //        else
    //        {
               
    //        }
        
    //    }
    }
}
