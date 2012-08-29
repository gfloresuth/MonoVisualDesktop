using System;
using System.Windows.Forms;
using System.Drawing;


namespace MonoVisualDesktop
{
	/// <summary>
	/// Main form. This is the main form
	/// </summary>
	public class MainForm : Form
	{
		/// <summary>
		/// The lbl info. This label is for information only.
		/// </summary>
		Label lblInfo;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="MonoVisualDesktop.MainForm"/> class.
		/// </summary>
		public MainForm ()
		{
			
			
			initControls();
			
		}
		/// <summary>
		/// Inits the controls.
		/// </summary>
		private void initControls()
		{
			// This form
			this.Size=new Size(480,320); // Sets the main window size
			this.FormBorderStyle = FormBorderStyle.FixedSingle; // Sets the type of window
			this.Text="Mono Visual Desktop"; // Sets the title
			this.StartPosition = FormStartPosition.CenterScreen; // Sets the default position (Center of the Screen).
			// lblInfo (label)
			lblInfo = new Label(); // Creates a new instance of Label
			lblInfo.Text = "Mono Visual Desktop, Created by: Gustavo Adolfo Flores González"; // Sets the text property
			lblInfo.Location = new Point(0,0); // Sets the startup position
			lblInfo.Dock = DockStyle.Top; // Doc the label to the top of the window.
			this.Controls.Add (lblInfo); // Adds lblInfo to the Window controls.
		}
	}
}

