using System.Collections.Generic;
using final_project.Actors;
using final_project.Services;

namespace final_project.Actions
{
    public class MoveActorsAction : Action
    {

        public MoveActorsAction()
        {
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> enemies = cast["enemies"];
            foreach (List<Actor> group in cast.Values)
            {
                foreach (Actor actor in group)
                {
                    MoveActor(actor);
                }
            }
            foreach(Actor enemy in enemies)
            {
                if(enemy.GetVelocity().GetX() <= 0)
                {
                    enemy.SetImage(Constants.ENEMY_LEFT_IMAGE);
                }
                else
                {
                    enemy.SetImage(Constants.ENEMY_RIGHT_IMAGE);
                }
            }
        }
        
        private void MoveActor(Actor actor)
        {
            
            int x = actor.GetX();
            int y = actor.GetY();

            int dx = actor.GetVelocity().GetX();
            int dy = actor.GetVelocity().GetY();

            int newX = (x + dx) % Constants.MAX_X;
            int newY = (y + dy) % Constants.MAX_Y;

            if (newX < 0)
            {
                newX = Constants.MAX_X;
                
            }

            if (newY < 0)
            {
                newY = Constants.MAX_Y;
            }

            actor.SetPosition(new Point(newX, newY));
        }

    }
}