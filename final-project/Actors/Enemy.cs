using System;
using Raylib_cs;
using System.Collections.Generic;

namespace final_project.Actors
{
    public class Enemy : Actor
    {
        public Enemy(Point position,Point velocity, int width, int height)
        {
            SetPosition(position);
            SetWidth(width);
            SetHeight(height);
            SetVelocity(velocity);
        }
    }
}