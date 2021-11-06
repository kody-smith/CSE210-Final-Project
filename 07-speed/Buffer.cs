using System;
using Raylib_cs;

namespace _07_speed
{
  class Buffer : Actor
  {
     InputService _inputService = new InputService();
     string word = "";
     string _userInput;
    

    public Buffer()
    {
      
      _position = new Point(0, Constants.MAX_Y - 25);
      _width = 0;
      _height = 0;

      // GetUserInput();
      
    }

    public string GetUserInput(string t)
    {
      return _userInput = t;
    }

    public string OnlyReturnUserInput()
    {
      return word;
    }
    // private string SetUserInput()
    // {
    //   return _userInput = GetUserInput();
    // }

    public void ResetBuffer()
    {
      if(_inputService.IsEnterPressed())
      {
        word = "";
      }
      
    }
    public void UpdateText()
    {
      _text = $"Buffer: {word}";
    }

    public void CombineLetter()
    {
      word += _userInput;
      UpdateText();
      
    }

  }
}
