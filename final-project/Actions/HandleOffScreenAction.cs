using System.Collections.Generic;
using final_project.Actors;
using final_project.Services;
using System;

namespace final_project.Actions
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();
        Random rnd = new Random();
        public HandleOffScreenAction(PhysicsService physicsService, AudioService audioService)
        {
            _physicsService = physicsService;
            _audioService = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
           List<Actor> enemies = cast["enemies"];
           Actor player = cast["player"][0];
           foreach(Actor enemy in enemies)
           {
                if(enemy.GetLeftEdge() <= 0)
                {
                    enemy.ChangeDX();

                }
                if(enemy.GetRightEdge() >= Constants.MAX_X)
                {
                    enemy.ChangeDX();
                }
                // if(enemy.GetTopEdge() <= 0)
                // {
                //     enemy.ChangeDY();
                // }
                // if(enemy.GetBottomEdge() >= Constants.MAX_Y)
                // {
                //     Director._keepPlaying = false;
                // } 
                
           }
        }

    }
}