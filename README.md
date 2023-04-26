# Lego Mindstorms EV3 (Firmware: V1.09H)

This application uses [DirectInput API](http://sharpdx.org/wiki/class-library-api/directinput/) however can be disabled by editing the **Joystick** and **MindstromController** project properties or changing the configuration to ReleaseWithoutJoystick.
Just remove the Conditional Compilation Symbol **USE_JOYSTICK** on the Build tab.

For those who want to contribute, please read the *CONTRIBUTING.md* in the root folder of the solution.

Using the code in another solution shouldn't be hard. Just reference the **MindstormCore** project and use the following code snippet.

It also uses ChatGPT to communicate with. In order to obtain a valid OpenAI API Key,
you need to create one at https://platform.openai.com/account/api-keys, and set it as an environment variable called OpenAI:ApiKey.
Developers can use this command to create a secret in developer console: dotnet user-secrets set "OpenAI:ApiKey" "openai-api-key"

## Connect to brick
```
var brick = new Brick("COM1"); // Note that you need to find the correct COM port to connect.
brick.Connect();
```

## Using the speaker
Play a melody
```
brick.PlayMusic(new KisKeceLányom());
```

Turn on the speaker
```
brick.Beep(frequecncy, durationInMs);
```

Turn off the speaker
```
brick.Silence();
```

Play embedded sounds
```
brick.PlaySound(EmbeddedSound.ElephantCall, PlayType.PlayOnce);
```

## Using the motors

Set motors
```
brick.SetMotors(OutputPort.B, OutputPort.C, OutputPort.D);
```

Start motors with different speed
```
var leftMotorSpeed = 100; // Minimum: -100, maximum: 100
var rightMotorSpeed = -100;
brick.SetMediumMotorSpeed(DaisyChainLayer.EV3, new SetMotorSpeedParams(brick.LeftMotor, leftMotorSpeed), new SetMotorSpeedParams(brick.RightMotor, rightMotorSpeed));
```

Stop Motors
```
brick.SetMediumMotorSpeed(DaisyChainLayer.EV3, new SetMotorSpeedParams(brick.Motors, 0));
or
brick.StopMotor(DaisyChainLayer.EV3, brick.Motors, BreakType.Break);
```

## Using the screen

Clear the screen
```
brick.ClearScreen();
```

Any drawing will be shown after this command is called
```
brick.UpdateScreen();
```

Put a pixel on the screen
```
brick.PutPixel(10, 10, LCDColor.Black);
or
brick.PutPixel(new EV3Point(10, 10), LCDColor.Black);
```

Draw text on screen
```
brick.DrawString(10, 10, "Hello World!", LCDColor.Black, FontType.Normal);
or
brick.DrawString(new EV3Text(new EV3Point(10, 10), "Hello World!"));
```

Create an *IEV3DrawingElement*
```
IEV3DrawingElement element = new EV3Circle(50, 50, 20, true);
or
IEV3DrawingElement element = new EV3Line(50, 50, 100, 100);
or
IEV3DrawingElement element = new EV3Point(10, 10);
or
IEV3DrawingElement element = new EV3Rectangle(10, 10, 90, 90, false);
or
IEV3DrawingElement element = new EV3Text(10, 10, "Hello World!");
```

Draw an *IEV3DrawingElement* on the screen
```
brick.Draw(element, LCDColor.Black);
```

Start a game
```
var snakeGameEngine = new SnakeGameEngine(brick);
snakeGameEngine.GameLoop();
or
var circlesGameEngine = new CirclesGameEngine(brick);
circlesGameEngine.GameLoop();
```

Note that if something goes wrong, press the Back, Left, and Center buttons on your EV3 device to restart it.