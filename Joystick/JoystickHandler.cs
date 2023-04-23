#if USE_JOYSTICK

using SharpDX.DirectInput;
using Action = System.Action;

namespace Joystick;

public static class JoystickHandler
{
    public static CancellationTokenSource? InitializeJoystick(
        Func<bool> continuePulling,
        Func<int> getDeltaModifier,
        Func<int> getMinimumDelta,

        Action<int, int> restAction,
        Action<int, int> forwardOrBackwardAction,
        Action<int, int> forwardWithLeftTurnAction,
        Action<int, int> forwardWithRightTurnAction,
        Action<int, int> backwardWithLeftTurnAction,
        Action<int, int> backwardWithRightTurnAction,
        Action<int, int> turnLeftOrRightAction,

        Action afterPullingAction,

        Action[] buttonActions)
    {
        var directInput = new DirectInput();
        var gameControlDevices = directInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly);

        foreach (var deviceInstance in gameControlDevices)
        {
            var joystick = new SharpDX.DirectInput.Joystick(directInput, deviceInstance.InstanceGuid);
            joystick.Properties.BufferSize = 128;
            joystick.Acquire();
            joystick.Poll();
            var state = joystick.GetCurrentState();
            var middleX = state.X;
            var middleY = state.Y;

            var joystickPollCancellationTokenSource = new CancellationTokenSource();
            Task.Factory.StartNew(() =>
            {
                while (continuePulling() && !joystickPollCancellationTokenSource.IsCancellationRequested)
                {
                    var deltaModifier = getDeltaModifier();
                    var minimumDelta = getMinimumDelta();
                    joystick.Poll();
                    state = joystick.GetCurrentState();
                    var deltaX = (state.X - middleX) / deltaModifier;
                    var deltaY = (middleY - state.Y) / deltaModifier;

                    if ((deltaX > -minimumDelta) && (deltaX < minimumDelta))
                    {
                        deltaX = 0;
                    }
                    if ((deltaY > -minimumDelta) && (deltaY < minimumDelta))
                    {
                        deltaY = 0;
                    }

                    if (deltaX == 0)
                    {
                        if (deltaY == 0)
                        {
                            restAction(deltaX, deltaY);
                        }
                        else
                        {
                            forwardOrBackwardAction(deltaX, deltaY);
                        }
                    }
                    else if (deltaY > minimumDelta)
                    {
                        if (deltaX < -minimumDelta)
                        {
                            forwardWithLeftTurnAction(deltaX, deltaY);
                        }
                        else if (deltaX > minimumDelta)
                        {
                            forwardWithRightTurnAction(deltaX, deltaY);
                        }
                    }
                    else if (deltaY < -minimumDelta)
                    {
                        if (deltaX < -minimumDelta)
                        {
                            backwardWithLeftTurnAction(deltaX, deltaY);
                        }
                        else if (deltaX > minimumDelta)
                        {
                            backwardWithRightTurnAction(deltaX, deltaY);
                        }
                    }
                    else if (deltaY == 0)
                    {
                        if (deltaX < -minimumDelta || deltaX > minimumDelta)
                        {
                            turnLeftOrRightAction(deltaX, deltaY);
                        }
                    }

                    var buttonStates = state.Buttons;
                    for (int i = 0; i < buttonStates.Length; i++)
                    {
                        if (buttonStates[i] && buttonActions.Length > i)
                        {
                            buttonActions[i]();
                        }
                    }

                    Thread.Sleep(100);
                }

                afterPullingAction();
            }, joystickPollCancellationTokenSource.Token);

            return joystickPollCancellationTokenSource;
        }

        return null;
    }

    public static void StopJoystick(CancellationTokenSource? joystickPollCancellationTokenSource)
    {
        joystickPollCancellationTokenSource?.Cancel();
    }
}

#endif