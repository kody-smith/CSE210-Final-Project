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
            // player
            cast["player"] = new List<Actor>();
            Player player = new Player(new Point(Constants.PLAYER_X,Constants.PLAYER_Y),Constants.PLAYER_WIDTH,Constants.PLAYER_HEIGHT);
            cast["player"].Add(player);
            // The Ball (or balls if desired)
            

            // TODO: Add your ball here

            // The paddle
            
            // TODO: Add your paddle here

            

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
