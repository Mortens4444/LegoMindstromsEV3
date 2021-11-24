#if USE_JOYSTICK

using Microsoft.DirectX.DirectInput;
using System;
using System.Threading;
using System.Threading.Tasks;
using Action = System.Action;

namespace Joystick
{
    public static class StickHandler
    {
        public static CancellationTokenSource InitializeJoystick(
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
            var gameControlDevices = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);
            if (gameControlDevices.Count > 0)
            {
                gameControlDevices.MoveNext();
                var deviceInstance = (DeviceInstance)gameControlDevices.Current;
                var joystick = new Device(deviceInstance.InstanceGuid);
                joystick.SetDataFormat(DeviceDataFormat.Joystick);
                joystick.Acquire();
                joystick.Poll();
                var state = joystick.CurrentJoystickState;
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
                        state = joystick.CurrentJoystickState;
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

                        var buttonStates = state.GetButtons();
                        for (int i = 0; i < buttonStates.Length; i++)
                        {
                            if (buttonStates[i] > 0 && buttonActions.Length > i)
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

        public static void StopJoystick(CancellationTokenSource joystickPollCancellationTokenSource)
        {
            if (joystickPollCancellationTokenSource != null)
            {
                joystickPollCancellationTokenSource.Cancel();
            }
        }
    }
}

#endif