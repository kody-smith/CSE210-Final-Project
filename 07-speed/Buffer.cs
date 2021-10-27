using System;
using Raylib_cs;

namespace _07_speed
{
  class buffer
  {
     InputService _inputService = new InputService();
     string _keyStrings;


    private string GetUserInput()
    {
      int keyInt = Raylib.GetKeyPressed();
      string keyString = "";
      if (keyInt != 0)
      {
       char keyChar = (char)keyInt;
       keyString = keyChar.ToString().ToLower();
      }
        return keyString;
    } 

    private string SetKeyStrings()
    {
      return _keyStrings = GetUserInput();
    }

    private void ResetBuffer()
    {
      
    }
  }
}
