using System.ComponentModel;

namespace Mindstorms.Core.Enums;

public enum EmbeddedImage
{
    [Description("3Gens")]
    [Category(EmbeddedImageTypes.Custom)]
    ThreeGenerations,

    [Description("Big smile")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    BigSmile,

    [Description("Heart large")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    HeartLarge,

    [Description("Heart small")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    HeartSmall,

    [Description("Mouth 1 open")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Mouth1Open,

    [Description("Mouth 1 shut")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Mouth1Shut,

    [Description("Mouth 2 open")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Mouth2Open,

    [Description("Mouth 2 shut")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Mouth2Shut,

    [Description("Sad")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Sad,

    [Description("Sick")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Sick,

    [Description("Smile")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Smile,

    [Description("Swearing")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Swearing,

    [Description("Talking")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Talking,

    [Description("Wink")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    Wink,

    [Description("Zzz")]
    [Category(EmbeddedImageTypes.FacialExpression)]
    ZZZ,

    [Description("Angry")]
    [Category(EmbeddedImageTypes.Eye)]
    Angry,

    [Description("Awake")]
    [Category(EmbeddedImageTypes.Eye)]
    Awake,

    [Description("Black eye")]
    [Category(EmbeddedImageTypes.Eye)]
    BlackEye,

    [Description("Bottom left")]
    [Category(EmbeddedImageTypes.Eye)]
    BottomLeft,

    [Description("Bottom right")]
    [Category(EmbeddedImageTypes.Eye)]
    BottomRight,

    [Description("Crazy 1")]
    [Category(EmbeddedImageTypes.Eye)]
    Crazy1,

    [Description("Crazy 2")]
    [Category(EmbeddedImageTypes.Eye)]
    Crazy2,

    [Description("Disappointed")]
    [Category(EmbeddedImageTypes.Eye)]
    Disappointed,

    [Description("Dizzy")]
    [Category(EmbeddedImageTypes.Eye)]
    Dizzy,

    [Description("Down")]
    [Category(EmbeddedImageTypes.Eye)]
    Down,

    [Description("Evil")]
    [Category(EmbeddedImageTypes.Eye)]
    Evil,

    [Description("Hurt")]
    [Category(EmbeddedImageTypes.Eye)]
    Hurt,

    [Description("Knocked out")]
    [Category(EmbeddedImageTypes.Eye)]
    KnockedOut,

    [Description("Love")]
    [Category(EmbeddedImageTypes.Eye)]
    Love,

    [Description("Middle left")]
    [Category(EmbeddedImageTypes.Eye)]
    MiddleLeft,

    [Description("Middle right")]
    [Category(EmbeddedImageTypes.Eye)]
    MiddleRight,

    [Description("Neutral")]
    [Category(EmbeddedImageTypes.Eye)]
    Neutral,

    [Description("Nuclear")]
    [Category(EmbeddedImageTypes.Eye)]
    Nuclear,

    [Description("Pinch left")]
    [Category(EmbeddedImageTypes.Eye)]
    PinchLeft,

    [Description("Pinch middle")]
    [Category(EmbeddedImageTypes.Eye)]
    PinchMiddle,

    [Description("Pinch right")]
    [Category(EmbeddedImageTypes.Eye)]
    PinchRight,

    [Description("Sleeping")]
    [Category(EmbeddedImageTypes.Eye)]
    Sleeping,

    [Description("Tear")]
    [Category(EmbeddedImageTypes.Eye)]
    Tear,

    [Description("Tired left")]
    [Category(EmbeddedImageTypes.Eye)]
    TiredLeft,

    [Description("Tired middle")]
    [Category(EmbeddedImageTypes.Eye)]
    TiredMiddle,

    [Description("Tired right")]
    [Category(EmbeddedImageTypes.Eye)]
    TiredRight,

    [Description("Toxic")]
    [Category(EmbeddedImageTypes.Eye)]
    Toxic,

    [Description("Up")]
    [Category(EmbeddedImageTypes.Eye)]
    Up,

    [Description("Winking")]
    [Category(EmbeddedImageTypes.Eye)]
    Winking,

    [Description("Accept")]
    [Category(EmbeddedImageTypes.Information)]
    Accept,

    [Description("Backward")]
    [Category(EmbeddedImageTypes.Information)]
    Backward,

    [Description("Decline")]
    [Category(EmbeddedImageTypes.Information)]
    Decline,

    [Description("Forward")]
    [Category(EmbeddedImageTypes.Information)]
    Forward,

    [Description("Left")]
    [Category(EmbeddedImageTypes.Information)]
    Left,

    [Description("No go")]
    [Category(EmbeddedImageTypes.Information)]
    NoGo,

    [Description("Question mark")]
    [Category(EmbeddedImageTypes.Information)]
    QuestionMark,

    [Description("Right")]
    [Category(EmbeddedImageTypes.Information)]
    Right,

    [Description("Stop 1")]
    [Category(EmbeddedImageTypes.Information)]
    Stop1,

    [Description("Stop 2")]
    [Category(EmbeddedImageTypes.Information)]
    Stop2,

    [Description("Thumbs down")]
    [Category(EmbeddedImageTypes.Information)]
    ThumbsDown,

    [Description("Thumbs up")]
    [Category(EmbeddedImageTypes.Information)]
    ThumbsUp,

    [Description("Warning")]
    [Category(EmbeddedImageTypes.Information)]
    Warning,

    [Description("Color sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    ColorSensor,

    [Description("EV3 icon")]
    [Category(EmbeddedImageTypes.Lego)]
    EV3Icon,

    [Description("EV3")]
    [Category(EmbeddedImageTypes.Lego)]
    EV3,

    [Description("Gyro sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    GyroSensor,

    [Description("IR beacon")]
    [Category(EmbeddedImageTypes.Lego)]
    IRBeacon,

    [Description("IR sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    IRSensor,

    [Description("Large motor")]
    [Category(EmbeddedImageTypes.Lego)]
    LargeMotor,

    [Description("LEGO")]
    [Category(EmbeddedImageTypes.Lego)]
    Lego,

    [Description("Medium motor")]
    [Category(EmbeddedImageTypes.Lego)]
    MediumMotor,

    [Description("MINDSTORMS")]
    [Category(EmbeddedImageTypes.Lego)]
    Mindstorms,

    [Description("Sound sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    SoundSensor,

    [Description("Temp sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    TemperatureSensor,

    [Description("Touch sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    TouchSensor,

    [Description("US sensor")]
    [Category(EmbeddedImageTypes.Lego)]
    USSensor,

    [Description("Bomb")]
    [Category(EmbeddedImageTypes.Object)]
    Bomb,

    [Description("Boom")]
    [Category(EmbeddedImageTypes.Object)]
    Boom,

    [Description("Fire")]
    [Category(EmbeddedImageTypes.Object)]
    Fire,

    [Description("Flowers")]
    [Category(EmbeddedImageTypes.Object)]
    Flowers,

    [Description("Forest")]
    [Category(EmbeddedImageTypes.Object)]
    Forest,

    [Description("Light off")]
    [Category(EmbeddedImageTypes.Object)]
    LightOff,

    [Description("Light on")]
    [Category(EmbeddedImageTypes.Object)]
    LightOn,

    [Description("Lightning")]
    [Category(EmbeddedImageTypes.Object)]
    Lightning,

    [Description("Night")]
    [Category(EmbeddedImageTypes.Object)]
    Night,

    [Description("Pirate")]
    [Category(EmbeddedImageTypes.Object)]
    Pirate,

    [Description("Snow")]
    [Category(EmbeddedImageTypes.Object)]
    Snow,

    [Description("Target")]
    [Category(EmbeddedImageTypes.Object)]
    Target,

    [Description("Bar 0")]
    [Category(EmbeddedImageTypes.Process)]
    Bar0,

    [Description("Bar 1")]
    [Category(EmbeddedImageTypes.Process)]
    Bar1,

    [Description("Bar 2")]
    [Category(EmbeddedImageTypes.Process)]
    Bar2,

    [Description("Bar 3")]
    [Category(EmbeddedImageTypes.Process)]
    Bar3,

    [Description("Bar 4")]
    [Category(EmbeddedImageTypes.Process)]
    Bar4,

    [Description("Dial 0")]
    [Category(EmbeddedImageTypes.Process)]
    Dial0,

    [Description("Dial 1")]
    [Category(EmbeddedImageTypes.Process)]
    Dial1,

    [Description("Dial 2")]
    [Category(EmbeddedImageTypes.Process)]
    Dial2,

    [Description("Dial 3")]
    [Category(EmbeddedImageTypes.Process)]
    Dial3,

    [Description("Dial 4")]
    [Category(EmbeddedImageTypes.Process)]
    Dial4,

    [Description("Dots 0")]
    [Category(EmbeddedImageTypes.Process)]
    Dots0,

    [Description("Dots 1")]
    [Category(EmbeddedImageTypes.Process)]
    Dots1,

    [Description("Dots 2")]
    [Category(EmbeddedImageTypes.Process)]
    Dots2,

    [Description("Dots 3")]
    [Category(EmbeddedImageTypes.Process)]
    Dots3,

    [Description("Hourglass 0")]
    [Category(EmbeddedImageTypes.Process)]
    Hourglass0,

    [Description("Hourglass 1")]
    [Category(EmbeddedImageTypes.Process)]
    Hourglass1,

    [Description("Hourglass 2")]
    [Category(EmbeddedImageTypes.Process)]
    Hourglass2,

    [Description("Timer 0")]
    [Category(EmbeddedImageTypes.Process)]
    Timer0,

    [Description("Timer 1")]
    [Category(EmbeddedImageTypes.Process)]
    Timer1,

    [Description("Timer 2")]
    [Category(EmbeddedImageTypes.Process)]
    Timer2,

    [Description("Timer 3")]
    [Category(EmbeddedImageTypes.Process)]
    Timer3,

    [Description("Timer 4")]
    [Category(EmbeddedImageTypes.Process)]
    Timer4,

    [Description("Water level 0")]
    [Category(EmbeddedImageTypes.Process)]
    WaterLevel0,

    [Description("Water level 1")]
    [Category(EmbeddedImageTypes.Process)]
    WaterLevel1,

    [Description("Water level 2")]
    [Category(EmbeddedImageTypes.Process)]
    WaterLevel2,

    [Description("Water level 3")]
    [Category(EmbeddedImageTypes.Process)]
    WaterLevel3,

    [Description("Accept 1")]
    [Category(EmbeddedImageTypes.System)]
    Accept1,

    [Description("Accept 2")]
    [Category(EmbeddedImageTypes.System)]
    Accept2,

    [Description("Alert")]
    [Category(EmbeddedImageTypes.System)]
    Alert,

    [Description("Box")]
    [Category(EmbeddedImageTypes.System)]
    Box,

    [Description("Decline 1")]
    [Category(EmbeddedImageTypes.System)]
    Decline1,

    [Description("Decline 2")]
    [Category(EmbeddedImageTypes.System)]
    Decline2,

    [Description("Dot empty")]
    [Category(EmbeddedImageTypes.System)]
    DotEmpty,

    [Description("Dot full")]
    [Category(EmbeddedImageTypes.System)]
    DotFull,

    [Description("EV3 small")]
    [Category(EmbeddedImageTypes.System)]
    EV3Small,

    [Description("Busy 0")]
    [Category(EmbeddedImageTypes.System)]
    Busy0,

    [Description("Busy 1")]
    [Category(EmbeddedImageTypes.System)]
    Busy1,

    [Description("Play")]
    [Category(EmbeddedImageTypes.System)]
    Play,

    [Description("Slider 0")]
    [Category(EmbeddedImageTypes.System)]
    Slider0,

    [Description("Slider 1")]
    [Category(EmbeddedImageTypes.System)]
    Slider1,

    [Description("Slider 2")]
    [Category(EmbeddedImageTypes.System)]
    Slider2,

    [Description("Slider 3")]
    [Category(EmbeddedImageTypes.System)]
    Slider3,

    [Description("Slider 4")]
    [Category(EmbeddedImageTypes.System)]
    Slider4,

    [Description("Slider 5")]
    [Category(EmbeddedImageTypes.System)]
    Slider5,

    [Description("Slider 6")]
    [Category(EmbeddedImageTypes.System)]
    Slider6,

    [Description("Slider 7")]
    [Category(EmbeddedImageTypes.System)]
    Slider7,

    [Description("Slider 8")]
    [Category(EmbeddedImageTypes.System)]
    Slider8
}
