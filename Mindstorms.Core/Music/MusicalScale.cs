namespace Mindstorms.Core.Music
{
    public class MusicalScale
    {
        public static readonly Dictionary<int, string> NoteNames = new()
        {
            {A0, "A0"},
            {As0_Bb0, "A#0/Bb0"},
            {B0, "B0"},
            {C1, "C1"},
            {Cs1_Db1, "C#1/Db1"},
            {D1, "D1"},
            {Ds1_Eb1, "D#1/Eb1"},
            {E1, "E1"},
            {F1, "F1"},
            {Fs1_Gb1, "F#1/Gb1"},
            {G1, "G1"},
            {Gs1_Ab1, "G#1/Ab1"},
            {A1, "A1"},
            {As1_Bb1, "A#1/Bb1"},
            {B1, "B1"},
            {C2, "C2"},
            {Cs2_Db2, "C#2/Db2"},
            {D2, "D2"},
            {Ds2_Eb2, "D#2/Eb2"},
            {E2, "E2"},
            {F2, "F2"},
            {Fs2_Gb2, "F#2/Gb2"},
            {G2, "G2"},
            {Gs2_Ab2, "G#2/Ab2"},
            {A2, "A2"},
            {As2_Bb2, "A#2/Bb2"},
            {B2, "B2"},
            {C3, "C3"},
            {Cs3_Db3, "C#3/Db3"},
            {D3, "D3"},
            {Ds3_Eb3, "D#3/Eb3"},
            {E3, "E3"},
            {F3, "F3"},
            {Fs3_Gb3, "F#3/Gb3"},
            {G3, "G3"},
            {Gs3_Ab3, "G#3/Ab3"},
            {A3, "A3"},
            {As3_Bb3, "A#3/Bb3"},
            {B3, "B3"},
            {C4, "C4"},
            {Cs4_Db4, "C#4/Db4"},
            {D4, "D4"},
            {Ds4_Eb4, "D#4/Eb4"},
            {E4, "E4"},
            {F4, "F4"},
            {Fs4_Gb4, "F#4/Gb4"},
            {G4, "G4"},
            {Gs4_Ab4, "G#4/Ab4"},
            {A4, "A4"},
            {As4_Bb4, "A#4/Bb4"},
            {B4, "B4"},
            {C5, "C5"},
            {Cs5_Db5, "C#5/Db5"},
            {D5, "D5"},
            {Ds5_Eb5, "D#5/Eb5"},
            {E5, "E5"},
            {F5, "F5"},
            {Fs5_Gb5, "F#5/Gb5"},
            {G5, "G5"},
            {Gs5_Ab5, "G#5/Ab5"},
            {A5, "A5"},
            {As5_Bb5, "A#5/Bb5"},
            {B5, "B5"},
            {C6, "C6"},
            {Cs6_Db6, "C#6/Db6"},
            {D6, "D6"},
            {Ds6_Eb6, "D#6/Eb6"},
            {E6, "E6"},
            {F6, "F6"},
            {Fs6_Gb6, "F#6/Gb6"},
            {G6, "G6"},
            {Gs6_Ab6, "G#6/Ab6"},
            {A6, "A6"},
            {As6_Bb6, "A#6/Bb6"},
            {B6, "B6"},
            {C7, "C7"},
            {Cs7_Db7, "C#7/Db7"},
            {D7, "D7"},
            {Ds7_Eb7, "D#7/Eb7"},
            {E7, "E7"},
            {F7, "F7"},
            {Fs7_Gb7, "F#7/Gb7"},
            {G7, "G7"},
            {Gs7_Ab7, "G#7/Ab7"},
            {A7, "A7"},
            {As7_Bb7, "A#7/Bb7"},
            {B7, "B7"},
            {C8, "C8"},
            {Cs8_Db8, "C#8/Db8"},
            {D8, "D8"},
            {Ds8_Eb8, "D#8/Eb8"},
            {E8, "E8"},
            {F8, "F8"},
            {Fs8_Gb8, "F#8/Gb8"},
            {G8, "G8"}
        };

        public const int A0 = -57;
        public const int As0_Bb0 = -56;
        public const int B0 = -55;
        public const int C1 = -54;
        public const int Cs1_Db1 = -53;
        public const int D1 = -52;
        public const int Ds1_Eb1 = -51;
        public const int E1 = -50;
        public const int F1 = -49;
        public const int Fs1_Gb1 = -48;
        public const int G1 = -47;
        public const int Gs1_Ab1 = -46;
        public const int A1 = -45;
        public const int As1_Bb1 = -44;
        public const int B1 = -43;
        public const int C2 = -42;
        public const int Cs2_Db2 = -41;
        public const int D2 = -40;
        public const int Ds2_Eb2 = -39;
        public const int E2 = -38;
        public const int F2 = -37;
        public const int Fs2_Gb2 = -36;
        public const int G2 = -35;
        public const int Gs2_Ab2 = -34;
        public const int A2 = -33;
        public const int As2_Bb2 = -32;
        public const int B2 = -31;
        public const int C3 = -30;
        public const int Cs3_Db3 = -29;
        public const int D3 = -28;
        public const int Ds3_Eb3 = -27;
        public const int E3 = -26;
        public const int F3 = -25;
        public const int Fs3_Gb3 = -24;
        public const int G3 = -23;
        public const int Gs3_Ab3 = -22;
        public const int A3 = -21;
        public const int As3_Bb3 = -20;
        public const int B3 = -19;
        public const int C4 = -18;
        public const int Cs4_Db4 = -17;
        public const int D4 = -16;
        public const int Ds4_Eb4 = -15;
        public const int E4 = -14;
        public const int F4 = -13;
        public const int Fs4_Gb4 = -12;
        public const int G4 = -11;
        public const int Gs4_Ab4 = -10;
        public const int A4 = 0;
        public const int As4_Bb4 = 1;
        public const int B4 = 2;
        public const int C5 = 3;
        public const int Cs5_Db5 = 4;
        public const int D5 = 5;
        public const int Ds5_Eb5 = 6;
        public const int E5 = 7;
        public const int F5 = 8;
        public const int Fs5_Gb5 = 9;
        public const int G5 = 10;
        public const int Gs5_Ab5 = 11;
        public const int A5 = 12;
        public const int As5_Bb5 = 13;
        public const int B5 = 14;
        public const int C6 = 15;
        public const int Cs6_Db6 = 16;
        public const int D6 = 17;
        public const int Ds6_Eb6 = 18;
        public const int E6 = 19;
        public const int F6 = 20;
        public const int Fs6_Gb6 = 21;
        public const int G6 = 22;
        public const int Gs6_Ab6 = 23;
        public const int A6 = 24;
        public const int As6_Bb6 = 25;
        public const int B6 = 26;
        public const int C7 = 27;
        public const int Cs7_Db7 = 28;
        public const int D7 = 29;
        public const int Ds7_Eb7 = 30;
        public const int E7 = 31;
        public const int F7 = 32;
        public const int Fs7_Gb7 = 33;
        public const int G7 = 34;
        public const int Gs7_Ab7 = 35;
        public const int A7 = 36;
        public const int As7_Bb7 = 37;
        public const int B7 = 38;
        public const int C8 = 39;
        public const int Cs8_Db8 = 40;
        public const int D8 = 41;
        public const int Ds8_Eb8 = 42;
        public const int E8 = 43;
        public const int F8 = 44;
        public const int Fs8_Gb8 = 45;
        public const int G8 = 46;
    }

}
