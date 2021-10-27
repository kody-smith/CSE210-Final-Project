using System;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        KeyboardKey _KeyboardKey = new KeyboardKey();
        public InputService()
        {

        }

        public bool IsAPressed()
        {
            return Raylib.IsKeyDown(KeyboardKey.KEY_A);
        }

        public bool IsEscapePressed()
        {
            return Raylib.IsKeyDown(KeyboardKey.KEY_ESCAPE);
        }

        
        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}