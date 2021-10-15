using System;
using System.Collections.Generic;
namespace _05_jumper
{
    class Word
    {
        public char[] _char_array;
        public char letter;
        public List<string> _dashes = new List<string>();
        public string dashes;
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
           int _wordchoice = rnd.Next(0,41);
           Console.WriteLine(_wordchoice);
           _chosenWord = _wordArray[_wordchoice];
           Console.WriteLine(_chosenWord);
       }

       ///<summary>
       //DisplayWord will check the count of the random word
       //and print dashed lines to show the user how many letters
       //are in the word
       ///</summary>
       public void DisplayWord()
       {
           _dashes.Clear();
           foreach (char letter in _chosenWord)
           {
                _dashes.Add("_");
                for(int i =0; i<_dashes.Count; i++)
                {
                    Console.Write("_");
                }
                // Console.Write("_");
                // dashes.ToString();
           }
           
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
       public string AddLetter(string dashes, char letter)
       {
           foreach (char dash in _chosenWord)
           {
               Console.Write(dashes.Replace(dash, letter));
           }
           return dashes;
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