using System;
using Raylib_cs;
using System.Collections.Generic;

namespace final_project.Actors
{
    public class Lives : Actor
    {
        public Lives(Point position, int width, int height)
        {
            SetPosition(position);
            SetWidth(width);
            SetHeight(height);
        }
    }
}