using System.ComponentModel;

namespace Mindstorms.Core.Enums
{
    public enum EmbeddedSound
    {
        [Description("Cat purr")]
        [Category(EmbeddedSoundTypes.Animal)]
        CatPurr,

        [Description("Dog bark 1")]
        [Category(EmbeddedSoundTypes.Animal)]
        DogBark1,
        
        [Description("Dog bark 2")]
        [Category(EmbeddedSoundTypes.Animal)]
        DogBark2,

        [Description("Dog growl")]
        [Category(EmbeddedSoundTypes.Animal)]
        DogGrowl,

        [Description("Dog sniff")]
        [Category(EmbeddedSoundTypes.Animal)]
        DogSniff,

        [Description("Dog whine")]
        [Category(EmbeddedSoundTypes.Animal)]
        DogWhine,

        [Description("Elephant call")]
        [Category(EmbeddedSoundTypes.Animal)]
        ElephantCall,

        [Description("Insect buzz 1")]
        [Category(EmbeddedSoundTypes.Animal)]
        InsectBuzz1,

        [Description("Insect buzz 2")]
        [Category(EmbeddedSoundTypes.Animal)]
        InsectBuzz2,

        [Description("Insect chirp")]
        [Category(EmbeddedSoundTypes.Animal)]
        InsectChirp,

        [Description("Snake hiss")]
        [Category(EmbeddedSoundTypes.Animal)]
        SnakeHiss,

        [Description("Snake rattle")]
        [Category(EmbeddedSoundTypes.Animal)]
        SnakeRattle,

        [Description("T-rex roar")]
        [Category(EmbeddedSoundTypes.Animal)]
        TRexRoar,

        [Description("Black")]
        [Category(EmbeddedSoundTypes.Color)]
        Black,

        [Description("Blue")]
        [Category(EmbeddedSoundTypes.Color)]
        Blue,

        [Description("Brown")]
        [Category(EmbeddedSoundTypes.Color)]
        Brown,

        [Description("Green")]
        [Category(EmbeddedSoundTypes.Color)]
        Green,

        [Description("Red")]
        [Category(EmbeddedSoundTypes.Color)]
        Red,

        [Description("White")]
        [Category(EmbeddedSoundTypes.Color)]
        White,

        [Description("Yellow")]
        [Category(EmbeddedSoundTypes.Color)]
        Yellow,

        [Description("Bravo")]
        [Category(EmbeddedSoundTypes.Communication)]
        Bravo,

        [Description("EV3")]
        [Category(EmbeddedSoundTypes.Communication)]
        EV3,

        [Description("Fantastic")]
        [Category(EmbeddedSoundTypes.Communication)]
        Fantastic,

        [Description("Game over")]
        [Category(EmbeddedSoundTypes.Communication)]
        GameOver,

        [Description("Go")]
        [Category(EmbeddedSoundTypes.Communication)]
        Go,

        [Description("Good job")]
        [Category(EmbeddedSoundTypes.Communication)]
        GoodJob,

        [Description("Goodbye")]
        [Category(EmbeddedSoundTypes.Communication)]
        Goodbye,

        [Description("Hello")]
        [Category(EmbeddedSoundTypes.Communication)]
        Hello,

        [Description("Hi")]
        [Category(EmbeddedSoundTypes.Communication)]
        Hi,

        [Description("LEGO")]
        [Category(EmbeddedSoundTypes.Communication)]
        LEGO,

        [Description("MINDSTORMS")]
        [Category(EmbeddedSoundTypes.Communication)]
        MINDSTORMS,

        [Description("Morning")]
        [Category(EmbeddedSoundTypes.Communication)]
        Morning,

        [Description("Okay")]
        [Category(EmbeddedSoundTypes.Communication)]
        Okay,

        [Description("Okey-dokey")]
        [Category(EmbeddedSoundTypes.Communication)]
        OkeyDokey,

        [Description("Sorry")]
        [Category(EmbeddedSoundTypes.Communication)]
        Sorry,

        [Description("Thank you")]
        [Category(EmbeddedSoundTypes.Communication)]
        ThankYou,

        [Description("Yes")]
        [Category(EmbeddedSoundTypes.Communication)]
        Yes,

        [Description("Boing")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Boing,

        [Description("Boo")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Boo,

        [Description("Cheering")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Cheering,

        [Description("Crunching")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Crunching,

        [Description("Crying")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Crying,

        [Description("Fanfare")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Fanfare,

        [Description("Kung fu")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        KungFu,

        [Description("Laughing 1")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Laughing1,

        [Description("Laughing 2")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Laughing2,

        [Description("Magic wand")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        MagicWand,

        [Description("Ouch")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Ouch,

        [Description("Shouting")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Shouting,

        [Description("Smack")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Smack,

        [Description("Sneezing")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Sneezing,

        [Description("Snoring")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        Snoring,

        [Description("Uh-oh")]
        [Category(EmbeddedSoundTypes.FacialExpression)]
        UhOh,

        [Description("Activate")]
        [Category(EmbeddedSoundTypes.Information)]
        Activate,

        [Description("Analyze")]
        [Category(EmbeddedSoundTypes.Information)]
        Analyze,

        [Description("Backwards")]
        [Category(EmbeddedSoundTypes.Information)]
        Backwards,

        [Description("Color")]
        [Category(EmbeddedSoundTypes.Information)]
        Color,

        [Description("Detected")]
        [Category(EmbeddedSoundTypes.Information)]
        Detected,

        [Description("Down")]
        [Category(EmbeddedSoundTypes.Information)]
        Down,

        [Description("Error alarm")]
        [Category(EmbeddedSoundTypes.Information)]
        ErrorAlarm,

        [Description("Error")]
        [Category(EmbeddedSoundTypes.Information)]
        Error,

        [Description("Flashing")]
        [Category(EmbeddedSoundTypes.Information)]
        Flashing,

        [Description("Forward")]
        [Category(EmbeddedSoundTypes.Information)]
        Forward,

        [Description("Left")]
        [Category(EmbeddedSoundTypes.Information)]
        Left,

        [Description("Turn")]
        [Category(EmbeddedSoundTypes.Information)]
        Turn,

        [Description("Object")]
        [Category(EmbeddedSoundTypes.Information)]
        Object,

        [Description("Up")]
        [Category(EmbeddedSoundTypes.Information)]
        Up,

        [Description("Right")]
        [Category(EmbeddedSoundTypes.Information)]
        Right,

        [Description("Searching")]
        [Category(EmbeddedSoundTypes.Information)]
        Searching,

        [Description("Start")]
        [Category(EmbeddedSoundTypes.Information)]
        Start,

        [Description("Stop")]
        [Category(EmbeddedSoundTypes.Information)]
        Stop,

        [Description("Touch")]
        [Category(EmbeddedSoundTypes.Information)]
        Touch,

        [Description("Air release")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        AirRelease,

        [Description("Airbrake")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Airbrake,

        [Description("Backing alert")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        BackingAlert,

        [Description("Blip 1")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Blip1,

        [Description("Blip 2")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Blip2,

        [Description("Blip 3")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Blip3,

        [Description("Blip 4")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Blip4,

        [Description("Horn 1")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Horn1,

        [Description("Horn 2")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Horn2,

        [Description("Laser")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Laser,

        [Description("Motor idle")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        MotorIdle,

        [Description("Motor start")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        MotorStart,

        [Description("Motor stop")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        MotorStop,

        [Description("Ratchet")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Ratchet,

        [Description("Sonar")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Sonar,

        [Description("Tick tack")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        TickTack,

        [Description("Walk")]
        [Category(EmbeddedSoundTypes.Mechanic)]
        Walk,

        [Description("Arm 1")]
        [Category(EmbeddedSoundTypes.Move)]
        Arm1,

        [Description("Arm 2")]
        [Category(EmbeddedSoundTypes.Move)]
        Arm2,

        [Description("Arm 3")]
        [Category(EmbeddedSoundTypes.Move)]
        Arm3,

        [Description("Arm 4")]
        [Category(EmbeddedSoundTypes.Move)]
        Arm4,

        [Description("Drop load")]
        [Category(EmbeddedSoundTypes.Move)]
        DropLoad,

        [Description("Lift load")]
        [Category(EmbeddedSoundTypes.Move)]
        LiftLoad,

        [Description("Servo 1")]
        [Category(EmbeddedSoundTypes.Move)]
        Servo1,

        [Description("Servo 2")]
        [Category(EmbeddedSoundTypes.Move)]
        Servo2,

        [Description("Servo 3")]
        [Category(EmbeddedSoundTypes.Move)]
        Servo3,

        [Description("Servo 4")]
        [Category(EmbeddedSoundTypes.Move)]
        Servo4,

        [Description("Slide load")]
        [Category(EmbeddedSoundTypes.Move)]
        SlideLoad,

        [Description("Snap")]
        [Category(EmbeddedSoundTypes.Move)]
        Snap,

        [Description("Speed down")]
        [Category(EmbeddedSoundTypes.Move)]
        SpeedDown,

        [Description("Speed idle")]
        [Category(EmbeddedSoundTypes.Move)]
        SpeedIdle,

        [Description("Start up")]
        [Category(EmbeddedSoundTypes.Move)]
        SpeedUp,

        [Description("Speeding")]
        [Category(EmbeddedSoundTypes.Move)]
        Speeding,

        [Description("Zero")]
        [Category(EmbeddedSoundTypes.Number)]
        Zero,

        [Description("One")]
        [Category(EmbeddedSoundTypes.Number)]
        One,

        [Description("Two")]
        [Category(EmbeddedSoundTypes.Number)]
        Two,

        [Description("Three")]
        [Category(EmbeddedSoundTypes.Number)]
        Three,

        [Description("Four")]
        [Category(EmbeddedSoundTypes.Number)]
        Four,

        [Description("Five")]
        [Category(EmbeddedSoundTypes.Number)]
        Five,

        [Description("Six")]
        [Category(EmbeddedSoundTypes.Number)]
        Six,

        [Description("Seven")]
        [Category(EmbeddedSoundTypes.Number)]
        Seven,

        [Description("Eight")]
        [Category(EmbeddedSoundTypes.Number)]
        Eight,

        [Description("Nine")]
        [Category(EmbeddedSoundTypes.Number)]
        Nine,

        [Description("Ten")]
        [Category(EmbeddedSoundTypes.Number)]
        Ten,

        [Description("Click")]
        [Category(EmbeddedSoundTypes.System)]
        Click,

        [Description("Confirm")]
        [Category(EmbeddedSoundTypes.System)]
        Confirm,

        [Description("Connect")]
        [Category(EmbeddedSoundTypes.System)]
        Connect,

        [Description("Download")]
        [Category(EmbeddedSoundTypes.System)]
        Download,

        [Description("General alert")]
        [Category(EmbeddedSoundTypes.System)]
        GeneralAlert,

        [Description("Overpower")]
        [Category(EmbeddedSoundTypes.System)]
        Overpower,

        [Description("Power down")]
        [Category(EmbeddedSoundTypes.System)]
        PowerDown,

        [Description("Ready")]
        [Category(EmbeddedSoundTypes.System)]
        Ready,

        [Description("Start up")]
        [Category(EmbeddedSoundTypes.System)]
        StartUp
    }
}
