namespace _05_jumper
{
    class Display
    {
        public int life = 4;
        public List<string> _Parachute ;

        // in this function Removelife
        // the number of life will be reduced if the user input
        // did not matched with generated words.
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
           
       }
       //DisplayWord will check the count of the random word
       //and print dashed lines to show the user how many letters
       //are in the word
       public void DisplayWord()
       {
           
       }
       //AddLetter is responsible for swaping the dash for the letter 
       //in the correct location if guessed correctly
       public void AddLetter()
       {

       }
    }
}