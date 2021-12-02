using System;
using Raylib_cs;
using final_project.Actors;

namespace final_project.Services
{
    /// <summary>
    /// Handles all the physics related parts of the game such as
    /// determining collisions.
    /// </summary>
    public class PhysicsService
    {
        public PhysicsService()
        {

        }

        /// <summary>
        /// Returns true if the two actors overlap.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsCollision(Actor first, Actor second)
        {
            int x1 = first.GetX();
            int y1 = first.GetY();
            int width1 = first.GetWidth();
            int height1 = first.GetHeight();

            Raylib_cs.Rectangle rectangle1
                = new Raylib_cs.Rectangle(x1, y1, width1, height1);

            int x2 = second.GetX();
            int y2 = second.GetY();
            int width2 = second.GetWidth();
            int height2 = second.GetHeight();

            Raylib_cs.Rectangle rectangle2
                = new Raylib_cs.Rectangle(x2, y2, width2, height2);

            return Raylib.CheckCollisionRecs(rectangle1, rectangle2);
        }
        public Point GetCollisionOverlap(Actor first, Actor second)
        {
            // Using approach from here: https://stackoverflow.com/a/56607347
            // The general idea is: Find the depth the first actor has gone into the
            // second one, and then the one with the smallest depth is our collision side.
            int firstHalfWidth = first.GetWidth() / 2;
            int firstHalfHeight = first.GetHeight() / 2;
            int secondHalfWidth = second.GetWidth() / 2;
            int secondHalfHeight = second.GetHeight() / 2;
            // Find the centers
            int firstCenterX = first.GetPosition().GetX() + firstHalfWidth;
            int firstCenterY = first.GetPosition().GetY() + firstHalfHeight;
            int secondCenterX = second.GetPosition().GetX() + secondHalfWidth;
            int secondCenterY = second.GetPosition().GetY() + secondHalfHeight;
            // Find the distance between centers
            int diffX = firstCenterX - secondCenterX;
            int diffY = firstCenterY - secondCenterY;
            // Figure out how close the objects can get without overlapping
            // (When they just barely touch, it's the distance from the center to
            // the edge of the first, which is half its width, and then the distance from the
            // edge of the second to its center which is half its width, etc.)
            int distanceToOverlapX = firstHalfWidth + secondHalfWidth;
            int distanceToOverlapY = firstHalfHeight + secondHalfHeight;
            // Now find the amount of depth of the overlap
            int depthX = Math.Abs(distanceToOverlapX) - Math.Abs(diffX);
            int depthY = Math.Abs(distanceToOverlapY) - Math.Abs(diffY);
            // Now set it to be negative if it overlapped from the left or top
            if (diffX > 0)
            {
                depthX *= -1;
            }
            if (diffY > 0)
            {
                depthY *= -1;
            }
            return new Point(depthX, depthY);

        }
    }

}