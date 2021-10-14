using System;
namespace _05_jumper
{
    class Word
    {
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
       ///returns bool value.
       ///</summary>
       public void CompareWord()
       {
           throw new NotImplementedException();
       }
    }
}