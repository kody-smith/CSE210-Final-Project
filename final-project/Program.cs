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
            Player player = new Player(new Point(Constants.PLAYER_X,Constants.PLAYER_Y),Constants.PLAYER_WIDTH,Constants.PLAYER_HEIGHT);
            cast["player"].Add(player);

            // The Enemies
            cast["enemies"] = new List<Actor>();
            Random rnd = new Random();
            int numberOfEnemies = 10;
            while(cast["enemies"].Count < numberOfEnemies)
            {
                int rndX = rnd.Next(10,Constants.ENEMY_X);
                int rndY = rnd.Next(10,Constants.ENEMY_Y);
                cast["enemies"].Add(new Enemy(new Point(rndX,rndY),new Point(2,0),Constants.ENEMY_WIDTH,Constants.ENEMY_HEIGHT));
            }

            // The Lives
            cast["lives"] = new List<Actor>();

            for(int x = 10; x < Constants.LIFE_MAX_X; x+=Constants.LIFE_WIDTH + Constants.LIFE_SPACE)
            {
                cast["lives"].Add(new Lives(new Point(x,10),Constants.LIFE_WIDTH,Constants.LIFE_HEIGHT));
            }
            

            // The walls
            cast["walls"] = new List<Actor>();
            // Opening tunnel
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-80,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+80,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+140,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+200,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+260,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+320,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+380,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-110,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-170,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-230,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-290,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-350,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-410,Constants.MAX_Y-320),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            // Center Wall(Left)
            cast["walls"].Add(new Walls(new Point(0,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(60,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(120,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(180,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(240,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(300,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(360,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(420,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(480,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(540,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(600,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(660,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(720,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(780,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(840,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(870,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            // Center Wall(Right)
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-60,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-120,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-240,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-300,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-360,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-420,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-480,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-540,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-600,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-660,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-720,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-780,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-840,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-900,(Constants.MAX_Y/2)-20),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            // Final Artifact Box
                //Left wall
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-280,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-280,60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-280,120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
                //Right Wall
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+280,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+280,60),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+280,120),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
                //Mouth
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-260,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-200,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)-140,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+230,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+170,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point((Constants.MAX_X/2)+110,150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            
            
            //Top Left Box
            cast["walls"].Add(new Walls(new Point(0,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(60,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(120,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(180,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(240,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(300,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point(330,270),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(330,210),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(330,30),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(330,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            //Top Right Box
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-60,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-120,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-240,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-300,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-360,300),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,270),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,210),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,30),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,0),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));

            //Bottom Left Maze
            cast["walls"].Add(new Walls(new Point(0,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(60,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(120,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-420),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-360),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(150,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point(180,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(240,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(300,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(360,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(420,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(480,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(540,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(600,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(660,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            //Bottom Right Maze
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-60,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-120,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-450),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-420),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-360),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-300),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-240),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-180,Constants.MAX_Y-180),Constants.VERT_WALL_WIDTH,Constants.VERT_WALL_HEIGHT));

            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-210,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-270,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-330,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-390,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-450,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-510,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-570,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-630,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            cast["walls"].Add(new Walls(new Point(Constants.MAX_X-690,Constants.MAX_Y-150),Constants.WALL_WIDTH,Constants.WALL_HEIGHT));
            
            // Artifacts
            // cast["artifact"] = new List<Actor>();
            // int numOfArtifacts = 5;
            // while(cast["artifact"].Count <= numOfArtifacts)
            // {
            //     int rndX = rnd.Next(10,Constants.ENEMY_X);
            //     int rndY = rnd.Next(10,Constants.ENEMY_Y);
            //     //Add Spacing using for loop?
            //     //Maybe add to specific locations
            //     cast["artifact"].Add(new Artifact(new Point(rndX,rndY),Constants.ARTIFACT_WIDTH,Constants.ARTIFACT_HEIGHT));
            // }

            // Power ups
            // cast["powerups"] = new List<Actor>();
            // int numOfPowerUps = 5;
            // while(cast["powerups"].Count <= numOfPowerUps)
            // {
            //     int rndX = rnd.Next(10,Constants.ENEMY_X);
            //     int rndY = rnd.Next(10,Constants.ENEMY_Y);
            //     cast["powerups"].Add(new PowerUp(new Point(rndX,rndY),Constants.POWERUP_WIDTH,Constants.POWERUP_HEIGHT));
            // }
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
            
            HandleCollisionsAction handleCollisionsAction = new HandleCollisionsAction(physicsService);
            script["update"].Add(handleCollisionsAction);

            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Top Down RPG", Constants.FRAME_RATE);
            // audioService.StartAudio();
            // audioService.PlaySound();

            Director theDirector = new Director(cast, script);
            theDirector.Direct();
            audioService.StopAudio();
        }
    }
}
