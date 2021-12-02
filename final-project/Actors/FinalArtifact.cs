using System;
using Raylib_cs;
using System.Collections.Generic;

namespace final_project.Actors
{
    public class FinalArtifact : Actor
    {
        public FinalArtifact(Point position, int width, int height)
        {
            SetPosition(position);
            SetWidth(width);
            SetHeight(height);
        }
    }
}