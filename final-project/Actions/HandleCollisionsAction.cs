using System.Collections.Generic;
using final_project.Actors;
using final_project.Services;
using System;

namespace final_project.Actions
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        InputService _inputService = new InputService();
        AudioService audioService = new AudioService();
        Random rnd = new Random();
        private int delay = 0;
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            
            if(delay > 0)
            {
                delay -= 1;
            }
            else 
            {
                Actor player = cast["player"][0];
                List<Actor> enemies = cast["enemies"];
                List<Actor> lives = cast["lives"];
                List<Actor> enemiesToRemove = new List<Actor>();
                
                foreach(Actor enemy in enemies)
                {
                    //Attack on enemy left side
                    if(player.GetX() < enemy.GetX() && enemy._velocity.GetX() == Constants.ENEMY_DX)
                    {
                        if(_physicsService.IsCollision(player,enemy) && _inputService.IsSpaceBarDown())
                        {
                            enemiesToRemove.Add(enemy);   
                        }
                    }
                    //Attack enemy on right side
                    if(player.GetX() > enemy.GetX() && enemy._velocity.GetX() == -Constants.ENEMY_DX)
                    {
                        if(_physicsService.IsCollision(player,enemy) && _inputService.IsSpaceBarDown())
                        {
                            enemiesToRemove.Add(enemy);   
                        }
                    }
                    //Remove life on collision on enemy left
                    if(player.GetX() > enemy.GetX() && enemy._velocity.GetX() == Constants.ENEMY_DX)
                    {
                        if(_physicsService.IsCollision(player,enemy))
                        {
                            cast["lives"].RemoveAt(lives.Count-1);
                            delay+= 50;
                        }
                    }
                    //Remove life on collision on enemy right
                    if(player.GetX() < enemy.GetX() && enemy._velocity.GetX() == -Constants.ENEMY_DX)
                    {
                        if(_physicsService.IsCollision(player,enemy))
                        {
                            cast["lives"].RemoveAt(lives.Count-1);
                            delay+= 50;
                        }
                    }
                }
                    foreach(Actor enemy in enemiesToRemove)
                    {
                        cast["enemies"].Remove(enemy);
                    }
            }
        }
    }
}