using System;
using Raylib_cs;
using System.Collections.Generic;

namespace final_project.Actors
{
    public class WinMessage : Actor
    {
        public WinMessage(Point position, string text)
        {
            SetPosition(position);
            SetText(text);
        }
    }
}