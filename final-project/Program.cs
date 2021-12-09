using System;
using final_project.Services;
using final_project.Actors;
using final_project.Actions;
using System.Collections.Generic;

namespace final_project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();
            Actor actor = new Actor();
            // The Player
            cast["player"] = new List<Actor>();
            Player player = new Player(new Point(Constants.PLAYER_X,Constants.PLAYER_Y),Constants.PLAYER_WIDTH,Constants.PLAYER_HEIGHT,Constants.PLAYER_UP_IMAGE);
            cast["player"].Add(player);

            // The Enemies
            cast["enemies"] = new List<Actor>();

            //Six side to side enemies
            cast["enemies"].Add(new Enemy(new Point(0,750),new Point(Constants.ENEMY_DX,Constants.ENEMY_DY),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT,Constants.ENEMY_RIGHT_IMAGE));
            cast["enemies"].Add(new Enemy(new Point(Constants.MAX_X-Constants.ENEMY_WIDTH,510),new Point(-Constants.ENEMY_DX,Constants.ENEMY_DY),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT,Constants.ENEMY_LEFT_IMAGE));

            cast["enemies"].Add(new Enemy(new Point(0,135),new Point(Constants.ENEMY_DX,Constants.ENEMY_DY),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT,Constants.ENEMY_RIGHT_IMAGE));
            cast["enemies"].Add(new Enemy(new Point(Constants.MAX_X-Constants.ENEMY_WIDTH,135),new Point(-Constants.ENEMY_DX,Constants.ENEMY_DY),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT,Constants.ENEMY_LEFT_IMAGE));

            cast["enemies"].Add(new Enemy(new Point(180,Constants.MAX_Y-240),new Point(Constants.ENEMY_DX,Constants.ENEMY_DY),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT,Constants.ENEMY_RIGHT_IMAGE));
            cast["enemies"].Add(new Enemy(new Point(Constants.MAX_X-240,Constants.MAX_Y-240),new Point(-Constants.ENEMY_DX,Constants.ENEMY_DY),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT,Constants.ENEMY_LEFT_IMAGE));

            // The Lives
            cast["lives"] = new List<Actor>();

            for(int x = 10; x < Constants.LIFE_MAX_X; x+=Constants.LIFE_WIDTH + Constants.LIFE_SPACE)
            {
                cast["lives"].Add(new Lives(new Point(x,10),Constants.LIFE_WIDTH,Constants.LIFE_HEIGHT,Constants.LIFE_IMAGE));
            }
            

            // The walls
            cast["walls"] = new List<Actor>();
            // Opening tunnel
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+140,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+200,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+260,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+320,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+380,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-110,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-170,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-230,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-290,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-350,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-410,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            // Center Wall(Left)
            cast["walls"].Add(new Walls(new Point(0,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(60,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(120,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(180,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(240,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(300,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(360,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(420,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(480,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(540,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(600,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(660,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(720,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(780,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(840,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(870,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            // Center Wall(Right)
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-60,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-120,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-240,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-300,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-360,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-420,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-480,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-540,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-600,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-660,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-720,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-780,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-840,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-900,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            // Final Artifact Box
                //Left wall
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-280,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-280,60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-280,120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
                //Right Wall
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+280,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+280,60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+280,120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
                //Mouth
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-260,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-200,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-140,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+230,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+170,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+110,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            
            
            //Top Left Box
            cast["walls"].Add(new Walls(new Point(0,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(60,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(120,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(180,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(240,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(300,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point(330,270),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(330,210),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(330,30),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(330,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            //Top Right Box
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-60,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-120,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-240,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-300,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-360,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,270),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,210),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,30),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));

            //Bottom Left Maze
            cast["walls"].Add(new Walls(new Point(0,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(60,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(120,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-420),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-360),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point(180,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(240,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(300,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(360,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(420,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(480,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(540,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(600,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(660,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            //Bottom Right Maze
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-60,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-120,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-420),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-360),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT,Constants.VERT_WALL_IMAGE));

            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-210,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-270,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-330,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-450,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-510,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-570,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-630,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-690,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT,Constants.WALL_IMAGE));
            //Door
            cast["door"] = new List<Actor>();
            cast["door"].Add(new Door(new Point((Constants.MAX_X/2)-80,150),Constants.DOOR_WIDTH,Constants.DOOR_HEIGHT, Constants.DOOR_IMAGE));
            
            // Key
            cast["key"] = new List<Actor>();
            cast["key"].Add(new Key(new Point(Constants.MAX_X-75,Constants.MAX_Y-350),Constants.KEY_WIDTH,Constants.KEY_HEIGHT, Constants.KEY_IMAGE));

            //Artifacts
            cast["artifacts"] = new List<Actor>();
            cast["artifacts"].Add(new Artifact(new Point(65,Constants.MAX_Y-350),Constants.ARTIFACT_WIDTH,Constants.ARTIFACT_HEIGHT, Constants.ARTIFACT_IMAGE));
            cast["artifacts"].Add(new Artifact(new Point(85,200),Constants.ARTIFACT_WIDTH,Constants.ARTIFACT_HEIGHT, Constants.ARTIFACT_IMAGE));
            cast["artifacts"].Add(new Artifact(new Point(Constants.MAX_X-85,200),Constants.ARTIFACT_WIDTH,Constants.ARTIFACT_HEIGHT, Constants.ARTIFACT_IMAGE));

            //Final Artifact
            cast["finalArtifact"] = new List<Actor>();
            cast["finalArtifact"].Add(new FinalArtifact(new Point(Constants.MAX_X/2,50),Constants.FINAL_ARTIFACT_WIDTH,Constants.FINAL_ARTIFACT_HEIGHT, Constants.FINAL_ARTIFACT_IMAGE));

            //Win message
            cast["winMessage"] = new List<Actor>();
            // if(cast["walls"].Count == 0)
            // {
            //     cast["winMessage"].Add(new WinMessage(new Point((Constants.MAX_X/2)-Constants.DEFAULT_FONT_SIZE,Constants.MAX_Y/2),text));
            // }
            // Power ups
            // cast["powerups"] = new List<Actor>();
            // cast["powerups"].Add(new PowerUp(new Point(550,25),Constants.POWERUP_WIDTH,Constants.POWERUP_HEIGHT));
            // cast["powerups"].Add(new PowerUp(new Point(Constants.MAX_X-550,25),Constants.POWERUP_WIDTH,Constants.POWERUP_HEIGHT));

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.
            MoveActorsAction moveActorsAction = new MoveActorsAction();
            script["update"].Add(moveActorsAction);

            HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction(physicsService,audioService);
            script["update"].Add(handleOffScreenAction);
            
            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService,audioService);
            script["update"].Add(handleCollisionsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService,audioService);
            script["input"].Add(controlActorsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Iowa James - and the Stealers of the Lost Artifacts", Constants.FRAME_RATE);
            audioService.StartAudio();

            Director theDirector = new Director(cast, script);
            theDirector.Direct();
            audioService.StopAudio();
        }
    }
}
