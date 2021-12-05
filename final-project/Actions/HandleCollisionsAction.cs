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
            Actor player = cast["player"][0];
            List<Actor> enemies = cast["enemies"];
            List<Actor> lives = cast["lives"];
            List<Actor> enemiesToRemove = new List<Actor>();
            Actor key = cast["key"][0];
            List<Actor> keysToRemove = new List<Actor>();
            Actor door = cast["door"][0];
            List<Actor> artifacts = cast["artifacts"];
            List<Actor> artifactsToRemove = new List<Actor>();
            Actor finalArtifact = cast["finalArtifact"][0];
            // List<Actor> powerUps = cast["powerups"];
            List<Actor> walls = cast["walls"];
            
            //Set cooldown time
            if(delay > 0)
            {
                delay -= 1;
            }
            else 
            {                
            //Collision with enemies
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
                            lives.RemoveAt(lives.Count-1);
                            delay+= 50;
                        }
                    }
                    //Remove life on collision on enemy right
                    if(player.GetX() < enemy.GetX() && enemy._velocity.GetX() == -Constants.ENEMY_DX)
                    {
                        if(_physicsService.IsCollision(player,enemy))
                        {
                            lives.RemoveAt(lives.Count-1);
                            delay+= 50;
                        }
                    }
                }
                    foreach(Actor enemy in enemiesToRemove)
                    {
                        cast["enemies"].Remove(enemy);
                    }
            }
            //Collision with keys
                if(_physicsService.IsCollision(key,player))
                {
                    while(door.GetX() >= 750)
                    {
                        door.SetPosition(new Point(door.GetX()-1,door.GetY()));
                    }
                }
            //Collision with Artifacts
                foreach(Actor artifact in artifacts)
                {
                    if(_physicsService.IsCollision(player,artifact))
                    {
                        artifactsToRemove.Add(artifact);
                    }
                }
                foreach(Actor artifact in artifactsToRemove)
                {
                    cast["artifacts"].Remove(artifact);
                }
            //Collision with Final Artifact
                if(_physicsService.IsCollision(player,finalArtifact))
                {
                    Director._keepPlaying = false;
                }
            //If lives are gone, end game
                if(lives.Count == 0)
                {
                    Director._keepPlaying = false;
                }
        }
    }
}