using Mindstorms.Core.EV3;
using Mindstorms.Core.Responses;

namespace Mindstorms.Game.General;

public class DirectionHandler
{
    private readonly IDirectable directable;

    public DirectionHandler(IDirectable directable)
    {
        this.directable = directable;
    }

    public ButtonStates HandleKeyPress(Brick brick)
    {
        var buttonStates = brick.GetButtonStates();
        if (buttonStates.IsRightButtonPressed())
        {
            directable.ChangeDirection(Direction.East);
        }
        else if (buttonStates.IsLeftButtonPressed())
        {
            directable.ChangeDirection(Direction.West);
        }
        else if (buttonStates.IsDownButtonPressed())
        {
            directable.ChangeDirection(Direction.South);
        }
        else if (buttonStates.IsUpButtonPressed())
        {
            directable.ChangeDirection(Direction.North);
        }
        return buttonStates;
    }
}
