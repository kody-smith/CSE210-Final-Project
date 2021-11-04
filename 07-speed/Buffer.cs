using System;
using Raylib_cs;

namespace _07_speed
{
  class Buffer : Actor
  {
     InputService _inputService = new InputService();
     KeyboardKey _userInput;

    public Buffer()
    {
      _position = new Point(0, Constants.MAX_Y - 25);
      _width = 0;
      _height = 0;

      GetUserInput();
      UpdateText();
    }

    private string GetUserInput()
    {
      int keyInt = Raylib.GetKeyPressed();
      string _userInput = "";
      if (keyInt != 0)
      {
        
       char keyChar = (char)keyInt;
       _userInput = keyChar.ToString().ToLower();
      }
      return _userInput;
    } 

    // private string SetUserInput()
    // {
    //   return _userInput = GetUserInput();
    // }

    private void ResetBuffer()
    {
      
      
    }
    private void UpdateText()
    {
      _text = $"Buffer: {_inputService.SetKeyPressed(_userInput)}";
    }

  }
}
