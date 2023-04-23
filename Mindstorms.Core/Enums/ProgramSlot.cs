namespace Mindstorms.Core.Enums;

public class ProgramSlot : EnumLikeObject<ProgramSlot>
{
    /// <summary>
    /// Program slot reserved for executing the user interface
    /// </summary>
    public static readonly ProgramSlot Gui = new(0x00, nameof(Gui));

    /// <summary>
    /// Program slot used to execute user projects, apps and tools
    /// </summary>
	public static readonly ProgramSlot User = new(0x01, nameof(User));

    /// <summary>
    /// Program slot used for direct commands received from external (c_com)
    /// </summary>
	public static readonly ProgramSlot Cmd = new(0x02, nameof(Cmd));

    /// <summary>
    /// Program slot used for direct commands coming from the user interface (c_ui)
    /// </summary>
	public static readonly ProgramSlot Term = new(0x03, nameof(Term));

    /// <summary>
    /// Program slot used to run the debug user interface
    /// </summary>
	public static readonly ProgramSlot Debug = new(0x04, nameof(Debug));

    /// <summary>
    /// ONLY VALID IN opPROGRAM_STOP
    /// </summary>
	public static readonly ProgramSlot Current = new(0xFF, nameof(Current));

	private ProgramSlot(byte value, string name) : base(value, name)
    {
		Values.Add(value, this);
	}

    public static implicit operator ProgramSlot(byte value)
    {
        return Values[value];
    }

    public static implicit operator byte(ProgramSlot value)
    {
        return value.Value;
    }
}
