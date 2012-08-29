using System;
using System.Windows.Forms;


namespace MonoVisualDesktop
{
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
		public static void Main (string[] args)
		{
			Console.WriteLine ("Starting..."); // A little debug info
			Application.Run (new MainForm()); // Starts the main window
			Console.WriteLine("This is the end..."); // Final text before it exits the App.
		}
	}
}
