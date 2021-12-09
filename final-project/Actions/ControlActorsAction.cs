using System.Collections.Generic;
using final_project.Actors;
using final_project.Services;

namespace final_project.Actions
{
    public class ControlActorsAction : Action
    {
        InputService _inputService;

        public ControlActorsAction(InputService inputService)
        {
            _inputService = inputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point direction = _inputService.GetDirection();
            
            Actor player = cast["player"][0];

            Point velocity = direction.Scale(Constants.PLAYER_SPEED);
            player.SetVelocity(velocity);
            if(_inputService.IsLeftPressed())
            {
                player.SetImage(Constants.PLAYER_LEFT_IMAGE);
            }
            if(_inputService.IsRightPressed())
            {
                player.SetImage(Constants.PLAYER_RIGHT_IMAGE);
            }
            if(_inputService.IsUpPressed())
            {
                player.SetImage(Constants.PLAYER_UP_IMAGE);
            }
            if(_inputService.IsDownPressed())
            {
                player.SetImage(Constants.PLAYER_DOWN_IMAGE);
            }
        }
    }
}