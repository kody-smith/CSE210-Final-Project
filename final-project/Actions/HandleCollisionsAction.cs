using System.Collections.Generic;
using final_project.Actors;
using final_project.Services;
using Raylib_cs;
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
        AudioService _audioService = new AudioService();
        Random rnd = new Random();
        private int delay = 0;
        public HandleCollisionsAction(PhysicsService physicsService, AudioService audioService)
        {
            _physicsService = physicsService;
            _audioService = audioService;
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
            string winText = "Congrats! You win";
            string loseText = "You lost! Try again!";
            List<Actor> winMessage = cast["winMessage"];
            
            

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
                    if(_physicsService.IsCollision(player,finalArtifact))
                    {
                        _audioService.PlaySound(Constants.WIN);
                        winMessage.Add(new WinMessage(new Point((Constants.MAX_X/2)-120,Constants.MAX_Y/2-200),winText));
                        enemy.SetVelocity(new Point(0,0)); 
                    }
                    //If lives are gone, end game
                    if(lives.Count == 0)
                    {
                        winMessage.Add(new WinMessage(new Point((Constants.MAX_X/2)-120,Constants.MAX_Y/2-200),loseText));
                        enemy.SetVelocity(new Point(0,0));
                        _audioService.PlaySound(Constants.GAME_OVER);
                    }
                    //Enemy bounce of wall
                    foreach(Actor wall in walls)
                    {
                        if(_physicsService.IsCollision(enemy,wall))
                        {
                            enemy.ChangeDX();
                        }
                        //Player collision

                        Point overlapWall = _physicsService.GetCollisionOverlap(player, wall);
                        if(_physicsService.IsCollision(player,wall))
                        {
                        if (Math.Abs(overlapWall.GetX()) < Math.Abs(overlapWall.GetY()))
                        {
                            // Depth was least along the x-axis, so that's our point of collision
                            if (overlapWall.GetX() > 0)
                            {
                                // Collision on the left
                                player.SetPosition(new Point(player.GetX()-5,(player.GetY()))); 
                            }
                            else
                            {
                                // Collision on the right
                                player.SetPosition(new Point(player.GetX()+5,(player.GetY()))); 
                                
                            }
                        }
                        else
                        {
                            // Collision on the y-axis
                            if (overlapWall.GetY() > 0)
                            {
                                // Collision on the top
                                player.SetPosition(new Point(player.GetX(),(player.GetY()-5))); 
                            }
                            else
                            {
                                // Collision on the bottom
                                player.SetPosition(new Point(player.GetX(),(player.GetY()+5))); 
                            }
                        }
                        }
                        Point overlapDoor = _physicsService.GetCollisionOverlap(player, door);
                        if(_physicsService.IsCollision(player,door))
                        {
                        if (Math.Abs(overlapDoor.GetX()) < Math.Abs(overlapDoor.GetY()))
                        {
                            // Depth was least along the x-axis, so that's our point of collision
                            if (overlapDoor.GetX() > 0)
                            {
                                // Collision on the left
                                player.SetPosition(new Point(player.GetX()-5,(player.GetY()))); 
                            }
                            else
                            {
                                // Collision on the right
                                player.SetPosition(new Point(player.GetX()+5,(player.GetY()))); 
                                
                            }
                        }
                        else
                        {
                            // Collision on the y-axis
                            if (overlapDoor.GetY() > 0)
                            {
                                // Collision on the top
                                player.SetPosition(new Point(player.GetX(),(player.GetY()-5))); 
                            }
                            else
                            {
                                // Collision on the bottom
                                player.SetPosition(new Point(player.GetX(),(player.GetY()+5))); 
                            }
                        }
                        }
            
                    }
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
                            _audioService.PlaySound(Constants.PAIN);
                        }
                    }
                    //Remove life on collision on enemy right
                    if(player.GetX() < enemy.GetX() && enemy._velocity.GetX() == -Constants.ENEMY_DX)
                    {
                        if(_physicsService.IsCollision(player,enemy))
                        {
                            lives.RemoveAt(lives.Count-1);
                            delay+= 50;
                            _audioService.PlaySound(Constants.PAIN);
                        }
                    }
                }
                    foreach(Actor enemy in enemiesToRemove)
                    {
                        cast["enemies"].Remove(enemy);
                    }
                //Collision with Final Artifact
                
            }
            //Collision with key
            if(artifacts.Count == 0)
            {
                if(_physicsService.IsCollision(key,player))
                {
                    while(door.GetX() >= 750)
                    {
                        door.SetPosition(new Point(door.GetX()-1,door.GetY()));
                        _audioService.PlaySound(Constants.LEVER);
                    }
                }
            }   
            //Collision with Artifacts
                foreach(Actor artifact in artifacts)
                {
                    if(_physicsService.IsCollision(player,artifact))
                    {
                        artifactsToRemove.Add(artifact);
                        _audioService.PlaySound(Constants.COLLECT_ARTIFACT);
                    }
                }
                foreach(Actor artifact in artifactsToRemove)
                {
                    cast["artifacts"].Remove(artifact);
                }
        }
    }
}