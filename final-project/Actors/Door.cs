using System;
using Raylib_cs;
using System.Collections.Generic;

namespace final_project.Actors
{
    public class Door : Actor
    {
        public Door(Point position, int width, int height, string image)
        {
            SetPosition(position);
            SetWidth(width);
            SetHeight(height);
            SetImage(image);
        }
    }
}