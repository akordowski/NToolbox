using System.Drawing.Printing;

namespace NToolbox.Drawing.Printing
{
	/// <summary>
	/// Provides a <see cref="IPrintable"/> interface.
	/// </summary>
	public interface IPrintable
	{
		#region Events
		/// <summary>
		/// Occurs when the <see cref="Print"/> method is called and before the printing process
		/// begins.
		/// </summary>
		event PrintEventHandler BeginPrint;

		/// <summary>
		/// Occurs when the printing process ends.
		/// </summary>
		event PrintEventHandler EndPrint;
		#endregion

		#region Methods
		/// <summary>
		/// Starts the printing process.
		/// </summary>
		void Print();
		#endregion
	}
}