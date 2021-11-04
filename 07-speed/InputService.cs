using System;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        KeyboardKey KeyboardKey = new KeyboardKey();
        public InputService()
        {
            
        }

        public KeyboardKey SetKeyPressed(KeyboardKey keyboardKey)
        {
            keyboardKey = KeyboardKey;
            return keyboardKey;
        }
        public KeyboardKey GetKeyPressed()
        {
            return KeyboardKey;
        }


        public bool IsEscapePressed()
        {
            return Raylib.IsKeyDown(KeyboardKey.KEY_ESCAPE);
        }

        public bool IsEnterPressed()
        {
            return Raylib.IsKeyDown(KeyboardKey.KEY_ENTER);
        }
        
        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }

        public string GetUserInput()
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
    }

}