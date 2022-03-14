#Lego Mindstorms EV3 (Firmware: V1.09H)

This application uses [Microsoft.DirectX.SDK](https://www.microsoft.com/en-us/download/details.aspx?id=6812) however can be disabled by editing the **Joystick** and **MindstromController** project properties or changing the configuration to ReleaseWithoutJoystick.
Just remove the Conditional Compilation Symbol **USE_JOYSTICK** on the Build tab.

For those who want to contribute, please read the *CONTRIBUTING.md* in the root folder of the solution.

Using the code in another solution shouldn't be hard. Just reference the **MindstormCore** project and use the following code snippet.

```
var brick = new Brick("COM1", OutputPort.B, OutputPort.C, OutputPort.A);
brick.Connect();
```

##Using the speaker
Play a melody
`brick.PlayMusic(new KisKeceLányom());`

Turn on the speaker
`brick.Beep(volume, frequecncy, durationInMs);`

Turn off the speaker
`brick.Silence();`

##Using the motors

Start motors with different speed
`brick.SetMediumMotorSpeed(new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));`

Stop Motors
`brick.SetMediumMotorSpeed(new SetMotorSpeedParams(brick.Motors, 0));`

##Using the screen
Clear the screen
`brick.ClearScreen();`

Any drawing will be shown after this command is called
`brick.UpdateScreen();`

Put a pixel on the screen
`brick.PutPixel(point);`

Draw text on screen
`brick.DrawString(text);`

Draw an *IEV3DrawingElement* on the screen
`brick.Draw(element, Color.Black, fill);`