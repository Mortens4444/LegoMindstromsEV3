using Mindstorms.Core.EV3;
using Mindstorms.Core.Responses;

namespace Mindstorms.Game.General
{
    public class MovingHandler
    {
        private readonly IMoveable moveable;

        public MovingHandler(IMoveable moveable)
        {
            this.moveable = moveable;
        }

        public ButtonStates HandleKeyPress(Brick brick)
        {
            var buttonStates = brick.GetButtonStates();
            moveable.MoveRight(buttonStates.IsRightButtonPressed());
            moveable.MoveLeft(buttonStates.IsLeftButtonPressed());
            moveable.MoveDown(buttonStates.IsDownButtonPressed());
            moveable.MoveUp(buttonStates.IsUpButtonPressed());
            return buttonStates;
        }
    }
}
