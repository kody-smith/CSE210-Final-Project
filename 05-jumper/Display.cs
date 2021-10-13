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
       public void DisplayWord()
       {
           
       }
       public void AddLetter()
       {

       }
    }
}