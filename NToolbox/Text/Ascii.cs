namespace NToolbox.Text
{
	/// <summary>
	/// ASCII character codes.
	/// </summary>
	public enum Ascii
	{
		#region Enums
		/// <summary>
		/// Null (NUL)
		/// </summary>
		Null = 0x00,

		/// <summary>
		/// Start Of Heading (SOH)
		/// </summary>
		StartOfHeading = 0x01,

		/// <summary>
		/// Start Of Text (STX)
		/// </summary>
		StartOfText = 0x02,

		/// <summary>
		/// End Of Text (ETX)
		/// </summary>
		EndOfText = 0x03,

		/// <summary>
		/// End Of Transmission (EOT)
		/// </summary>
		EndOfTransmission = 0x04,

		/// <summary>
		/// Enquiry (ENQ)
		/// </summary>
		Enquiry = 0x05,

		/// <summary>
		/// Acknowledge (ACK)
		/// </summary>
		Acknowledge = 0x06,

		/// <summary>
		/// Bell (BEL)
		/// </summary>
		Bell = 0x07,

		/// <summary>
		/// Backspace (BS)
		/// </summary>
		Backspace = 0x08,

		/// <summary>
		/// Horizontal Tab (TAB)
		/// </summary>
		HorizontalTab = 0x09,

		/// <summary>
		/// Line Feed (New Line) (LF)
		/// </summary>
		LineFeed = 0x0A,

		/// <summary>
		/// Vertical Tab (VT)
		/// </summary>
		VerticalTab = 0x0B,

		/// <summary>
		/// Form Feed (New Page) (FF)
		/// </summary>
		FormFeed = 0x0C,

		/// <summary>
		/// Carriage Return (CR)
		/// </summary>
		CarriageReturn = 0x0D,

		/// <summary>
		/// Shift Out (SO)
		/// </summary>
		ShiftOut = 0x0E,

		/// <summary>
		/// Shift In (SI)
		/// </summary>
		ShiftIn = 0x0F,

		/// <summary>
		/// Data Link Escape (DLE)
		/// </summary>
		DataLinkEscape = 0x10,

		/// <summary>
		/// Device Control 1 (DC1)
		/// </summary>
		DeviceControl1 = 0x11,

		/// <summary>
		/// Device Control 2 (DC2)
		/// </summary>
		DeviceControl2 = 0x12,

		/// <summary>
		/// Device Control 3 (DC3)
		/// </summary>
		DeviceControl3 = 0x13,

		/// <summary>
		/// Device Control 4 (DC4)
		/// </summary>
		DeviceControl4 = 0x14,

		/// <summary>
		/// Negative Acknowledge (NAK)
		/// </summary>
		NegativeAcknowledge = 0x15,

		/// <summary>
		/// Synchronous Idle (SYN)
		/// </summary>
		SynchronousIdle = 0x16,

		/// <summary>
		/// End Of Transmission Block (ETB)
		/// </summary>
		EndOfTransmissionBlock = 0x17,

		/// <summary>
		/// Cancel (CAN)
		/// </summary>
		Cancel = 0x18,

		/// <summary>
		/// End Of Medium (EM)
		/// </summary>
		EndOfMedium = 0x19,

		/// <summary>
		/// Substitute (SUB)
		/// </summary>
		Substitute = 0x1A,

		/// <summary>
		/// Escape (ESC)
		/// </summary>
		Escape = 0x1B,

		/// <summary>
		/// File Separator (FS)
		/// </summary>
		FileSeparator = 0x1C,

		/// <summary>
		/// Group Separator (GS)
		/// </summary>
		GroupSeparator = 0x1D,

		/// <summary>
		/// Record Separator (RS)
		/// </summary>
		RecordSeparator = 0x1E,

		/// <summary>
		/// Unit Separator (US)
		/// </summary>
		UnitSeparator = 0x1F,

		/// <summary>
		/// Space
		/// </summary>
		Space = 0x20,

		/// <summary>
		/// !
		/// </summary>
		ExclamationMark = 0x21,

		/// <summary>
		/// "
		/// </summary>
		DoubleQuotes = 0x22,

		/// <summary>
		/// #
		/// </summary>
		Number = 0x23,

		/// <summary>
		/// $
		/// </summary>
		Dollar = 0x24,

		/// <summary>
		/// %
		/// </summary>
		Percent = 0x25,

		/// <summary>
		/// &amp;
		/// </summary>
		Ampersand = 0x26,

		/// <summary>
		/// '
		/// </summary>
		SingleQuote = 0x27,

		/// <summary>
		/// (
		/// </summary>
		OpeningParenthesis = 0x28,

		/// <summary>
		/// )
		/// </summary>
		ClosingParenthesis = 0x29,

		/// <summary>
		/// *
		/// </summary>
		Asterisk = 0x2A,

		/// <summary>
		/// +
		/// </summary>
		Plus = 0x2B,

		/// <summary>
		/// ,
		/// </summary>
		Comma = 0x2C,

		/// <summary>
		/// -
		/// </summary>
		Minus = 0x2D,

		/// <summary>
		/// .
		/// </summary>
		Dot = 0x2E,

		/// <summary>
		/// /
		/// </summary>
		Slash = 0x2F,

		/// <summary>
		/// 0
		/// </summary>
		Zero = 0x30,

		/// <summary>
		/// 1
		/// </summary>
		One = 0x31,

		/// <summary>
		/// 2
		/// </summary>
		Two = 0x32,

		/// <summary>
		/// 3
		/// </summary>
		Three = 0x33,

		/// <summary>
		/// 4
		/// </summary>
		Four = 0x34,

		/// <summary>
		/// 5
		/// </summary>
		Five = 0x35,

		/// <summary>
		/// 6
		/// </summary>
		Six = 0x36,

		/// <summary>
		/// 7
		/// </summary>
		Seven = 0x37,

		/// <summary>
		/// 8
		/// </summary>
		Eight = 0x38,

		/// <summary>
		/// 9
		/// </summary>
		Nine = 0x39,

		/// <summary>
		/// :
		/// </summary>
		Colon = 0x3A,

		/// <summary>
		/// ;
		/// </summary>
		Semicolon = 0x3B,

		/// <summary>
		/// &lt;
		/// </summary>
		LessThan = 0x3C,

		/// <summary>
		/// =
		/// </summary>
		Equal = 0x3D,

		/// <summary>
		/// &gt;
		/// </summary>
		GreaterThan = 0x3E,

		/// <summary>
		/// ?
		/// </summary>
		QuestionMark = 0x3F,

		/// <summary>
		/// @
		/// </summary>
		AtSymbol = 0x40,

		/// <summary>
		/// A
		/// </summary>
		UpperA = 0x41,

		/// <summary>
		/// B
		/// </summary>
		UpperB = 0x42,

		/// <summary>
		/// C
		/// </summary>
		UpperC = 0x43,

		/// <summary>
		/// D
		/// </summary>
		UpperD = 0x44,

		/// <summary>
		/// E
		/// </summary>
		UpperE = 0x45,

		/// <summary>
		/// F
		/// </summary>
		UpperF = 0x46,

		/// <summary>
		/// G
		/// </summary>
		UpperG = 0x47,

		/// <summary>
		/// H
		/// </summary>
		UpperH = 0x48,

		/// <summary>
		/// I
		/// </summary>
		UpperI = 0x49,

		/// <summary>
		/// J
		/// </summary>
		UpperJ = 0x4A,

		/// <summary>
		/// K
		/// </summary>
		UpperK = 0x4B,

		/// <summary>
		/// L
		/// </summary>
		UpperL = 0x4C,

		/// <summary>
		/// M
		/// </summary>
		UpperM = 0x4D,

		/// <summary>
		/// N
		/// </summary>
		UpperN = 0x4E,

		/// <summary>
		/// O
		/// </summary>
		UpperO = 0x4F,

		/// <summary>
		/// P
		/// </summary>
		UpperP = 0x50,

		/// <summary>
		/// Q
		/// </summary>
		UpperQ = 0x51,

		/// <summary>
		/// R
		/// </summary>
		UpperR = 0x52,

		/// <summary>
		/// S
		/// </summary>
		UpperS = 0x53,

		/// <summary>
		/// T
		/// </summary>
		UpperT = 0x54,

		/// <summary>
		/// U
		/// </summary>
		UpperU = 0x55,

		/// <summary>
		/// V
		/// </summary>
		UpperV = 0x56,

		/// <summary>
		/// W
		/// </summary>
		UpperW = 0x57,

		/// <summary>
		/// X
		/// </summary>
		UpperX = 0x58,

		/// <summary>
		/// Y
		/// </summary>
		UpperY = 0x59,

		/// <summary>
		/// Z
		/// </summary>
		UpperZ = 0x5A,

		/// <summary>
		/// [
		/// </summary>
		OpeningBracket = 0x5B,

		/// <summary>
		/// \
		/// </summary>
		Backslash = 0x5C,

		/// <summary>
		/// ]
		/// </summary>
		ClosingBracket = 0x5D,

		/// <summary>
		/// ^
		/// </summary>
		Caret = 0x5E,

		/// <summary>
		/// _
		/// </summary>
		Underscore = 0x5F,

		/// <summary>
		/// `
		/// </summary>
		GraveAccent = 0x60,

		/// <summary>
		/// a
		/// </summary>
		LowerA = 0x61,

		/// <summary>
		/// b
		/// </summary>
		LowerB = 0x62,

		/// <summary>
		/// c
		/// </summary>
		LowerC = 0x63,

		/// <summary>
		/// d
		/// </summary>
		LowerD = 0x64,

		/// <summary>
		/// e
		/// </summary>
		LowerE = 0x65,

		/// <summary>
		/// f
		/// </summary>
		LowerF = 0x66,

		/// <summary>
		/// g
		/// </summary>
		LowerG = 0x67,

		/// <summary>
		/// h
		/// </summary>
		LowerH = 0x68,

		/// <summary>
		/// i
		/// </summary>
		LowerI = 0x69,

		/// <summary>
		/// j
		/// </summary>
		LowerJ = 0x6A,

		/// <summary>
		/// k
		/// </summary>
		LowerK = 0x6B,

		/// <summary>
		/// l
		/// </summary>
		LowerL = 0x6C,

		/// <summary>
		/// m
		/// </summary>
		LowerM = 0x6D,

		/// <summary>
		/// n
		/// </summary>
		LowerN = 0x6E,

		/// <summary>
		/// o
		/// </summary>
		LowerO = 0x6F,

		/// <summary>
		/// p
		/// </summary>
		LowerP = 0x70,

		/// <summary>
		/// q
		/// </summary>
		LowerQ = 0x71,

		/// <summary>
		/// r
		/// </summary>
		LowerR = 0x72,

		/// <summary>
		/// s
		/// </summary>
		LowerS = 0x73,

		/// <summary>
		/// t
		/// </summary>
		LowerT = 0x74,

		/// <summary>
		/// u
		/// </summary>
		LowerU = 0x75,

		/// <summary>
		/// v
		/// </summary>
		LowerV = 0x76,

		/// <summary>
		/// w
		/// </summary>
		LowerW = 0x77,

		/// <summary>
		/// x
		/// </summary>
		LowerX = 0x78,

		/// <summary>
		/// y
		/// </summary>
		LowerY = 0x79,

		/// <summary>
		/// z
		/// </summary>
		LowerZ = 0x7A,

		/// <summary>
		/// {
		/// </summary>
		OpeningBrace = 0x7B,

		/// <summary>
		/// |
		/// </summary>
		Pipe = 0x7C,

		/// <summary>
		/// }
		/// </summary>
		ClosingBrace = 0x7D,

		/// <summary>
		/// ~
		/// </summary>
		Tilde = 0x7E,

		/// <summary>
		/// Delete (DEL)
		/// </summary>
		Delete = 0x7F
		#endregion
	}
}