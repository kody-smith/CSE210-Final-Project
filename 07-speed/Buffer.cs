using System;
using Raylib_cs;

namespace _07_speed
{
  class Buffer : Actor
  {
     InputService _inputService = new InputService();
     string _keyStrings;

    public Buffer()
    {
      _position = new Point(0, Constants.MAX_Y - 25);
      _width = 0;
      _height = 0;

      // UpdateText();
    }

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
