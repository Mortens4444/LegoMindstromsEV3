namespace Mindstorms.Core.Enums
{
    public enum ProgramSlot
	{
		/// <summary>
		/// Program slot reserved for executing the user interface
		/// </summary>
		Gui = 0, 
		
		/// <summary>
		/// Program slot used to execute user projects, apps and tools
		/// </summary>
		User = 1,
		
		/// <summary>
		/// Program slot used for direct commands coming from c_com
		/// </summary>
		Cmd = 2,
		
		/// <summary>
		/// Program slot used for direct commands coming from c_ui
		/// </summary>
		Term = 3,
		
		/// <summary>
		/// Program slot used to run the debug ui
		/// </summary>
		Debug = 4,
		
		/// <summary>
		/// ONLY VALID IN opPROGRAM_STOP
		/// </summary>
		Current = -1
    }
}
