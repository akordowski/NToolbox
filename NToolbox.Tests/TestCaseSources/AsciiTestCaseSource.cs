using NToolbox.Text;
using NUnit.Framework;
using System;
using System.Collections;

namespace NToolbox.Tests.TestCaseSources
{
	public static class AsciiTestCaseSource
	{
		#region Test Case Sources
		public static IEnumerable Ascii_TestCases()
		{
			yield return new TestCaseData(Ascii.Null, 0x00, null);
			yield return new TestCaseData(Ascii.StartOfHeading, 0x01, null);
			yield return new TestCaseData(Ascii.StartOfText, 0x02, null);
			yield return new TestCaseData(Ascii.EndOfText, 0x03, null);
			yield return new TestCaseData(Ascii.EndOfTransmission, 0x04, null);
			yield return new TestCaseData(Ascii.Enquiry, 0x05, null);
			yield return new TestCaseData(Ascii.Acknowledge, 0x06, null);
			yield return new TestCaseData(Ascii.Bell, 0x07, null);
			yield return new TestCaseData(Ascii.Backspace, 0x08, null);
			yield return new TestCaseData(Ascii.HorizontalTab, 0x09, null);
			yield return new TestCaseData(Ascii.LineFeed, 0x0A, null);
			yield return new TestCaseData(Ascii.VerticalTab, 0x0B, null);
			yield return new TestCaseData(Ascii.FormFeed, 0x0C, null);
			yield return new TestCaseData(Ascii.CarriageReturn, 0x0D, null);
			yield return new TestCaseData(Ascii.ShiftOut, 0x0E, null);
			yield return new TestCaseData(Ascii.ShiftIn, 0x0F, null);

			yield return new TestCaseData(Ascii.DataLinkEscape, 0x10, null);
			yield return new TestCaseData(Ascii.DeviceControl1, 0x11, null);
			yield return new TestCaseData(Ascii.DeviceControl2, 0x12, null);
			yield return new TestCaseData(Ascii.DeviceControl3, 0x13, null);
			yield return new TestCaseData(Ascii.DeviceControl4, 0x14, null);
			yield return new TestCaseData(Ascii.NegativeAcknowledge, 0x15, null);
			yield return new TestCaseData(Ascii.SynchronousIdle, 0x16, null);
			yield return new TestCaseData(Ascii.EndOfTransmissionBlock, 0x17, null);
			yield return new TestCaseData(Ascii.Cancel, 0x18, null);
			yield return new TestCaseData(Ascii.EndOfMedium, 0x19, null);
			yield return new TestCaseData(Ascii.Substitute, 0x1A, null);
			yield return new TestCaseData(Ascii.Escape, 0x1B, null);
			yield return new TestCaseData(Ascii.FileSeparator, 0x1C, null);
			yield return new TestCaseData(Ascii.GroupSeparator, 0x1D, null);
			yield return new TestCaseData(Ascii.RecordSeparator, 0x1E, null);
			yield return new TestCaseData(Ascii.UnitSeparator, 0x1F, null);

			yield return new TestCaseData(Ascii.Space, 0x20, ' ');
			yield return new TestCaseData(Ascii.ExclamationMark, 0x21, '!');
			yield return new TestCaseData(Ascii.DoubleQuotes, 0x22, '"');
			yield return new TestCaseData(Ascii.Number, 0x23, '#');
			yield return new TestCaseData(Ascii.Dollar, 0x24, '$');
			yield return new TestCaseData(Ascii.Percent, 0x25, '%');
			yield return new TestCaseData(Ascii.Ampersand, 0x26, '&');
			yield return new TestCaseData(Ascii.SingleQuote, 0x27, '\'');
			yield return new TestCaseData(Ascii.OpeningParenthesis, 0x28, '(');
			yield return new TestCaseData(Ascii.ClosingParenthesis, 0x29, ')');
			yield return new TestCaseData(Ascii.Asterisk, 0x2A, '*');
			yield return new TestCaseData(Ascii.Plus, 0x2B, '+');
			yield return new TestCaseData(Ascii.Comma, 0x2C, ',');
			yield return new TestCaseData(Ascii.Minus, 0x2D, '-');
			yield return new TestCaseData(Ascii.Dot, 0x2E, '.');
			yield return new TestCaseData(Ascii.Slash, 0x2F, '/');

			yield return new TestCaseData(Ascii.Zero, 0x30, '0');
			yield return new TestCaseData(Ascii.One, 0x31, '1');
			yield return new TestCaseData(Ascii.Two, 0x32, '2');
			yield return new TestCaseData(Ascii.Three, 0x33, '3');
			yield return new TestCaseData(Ascii.Four, 0x34, '4');
			yield return new TestCaseData(Ascii.Five, 0x35, '5');
			yield return new TestCaseData(Ascii.Six, 0x36, '6');
			yield return new TestCaseData(Ascii.Seven, 0x37, '7');
			yield return new TestCaseData(Ascii.Eight, 0x38, '8');
			yield return new TestCaseData(Ascii.Nine, 0x39, '9');
			yield return new TestCaseData(Ascii.Colon, 0x3A, ':');
			yield return new TestCaseData(Ascii.Semicolon, 0x3B, ';');
			yield return new TestCaseData(Ascii.LessThan, 0x3C, '<');
			yield return new TestCaseData(Ascii.Equal, 0x3D, '=');
			yield return new TestCaseData(Ascii.GreaterThan, 0x3E, '>');
			yield return new TestCaseData(Ascii.QuestionMark, 0x3F, '?');

			yield return new TestCaseData(Ascii.AtSymbol, 0x40, '@');
			yield return new TestCaseData(Ascii.UpperA, 0x41, 'A');
			yield return new TestCaseData(Ascii.UpperB, 0x42, 'B');
			yield return new TestCaseData(Ascii.UpperC, 0x43, 'C');
			yield return new TestCaseData(Ascii.UpperD, 0x44, 'D');
			yield return new TestCaseData(Ascii.UpperE, 0x45, 'E');
			yield return new TestCaseData(Ascii.UpperF, 0x46, 'F');
			yield return new TestCaseData(Ascii.UpperG, 0x47, 'G');
			yield return new TestCaseData(Ascii.UpperH, 0x48, 'H');
			yield return new TestCaseData(Ascii.UpperI, 0x49, 'I');
			yield return new TestCaseData(Ascii.UpperJ, 0x4A, 'J');
			yield return new TestCaseData(Ascii.UpperK, 0x4B, 'K');
			yield return new TestCaseData(Ascii.UpperL, 0x4C, 'L');
			yield return new TestCaseData(Ascii.UpperM, 0x4D, 'M');
			yield return new TestCaseData(Ascii.UpperN, 0x4E, 'N');
			yield return new TestCaseData(Ascii.UpperO, 0x4F, 'O');

			yield return new TestCaseData(Ascii.UpperP, 0x50, 'P');
			yield return new TestCaseData(Ascii.UpperQ, 0x51, 'Q');
			yield return new TestCaseData(Ascii.UpperR, 0x52, 'R');
			yield return new TestCaseData(Ascii.UpperS, 0x53, 'S');
			yield return new TestCaseData(Ascii.UpperT, 0x54, 'T');
			yield return new TestCaseData(Ascii.UpperU, 0x55, 'U');
			yield return new TestCaseData(Ascii.UpperV, 0x56, 'V');
			yield return new TestCaseData(Ascii.UpperW, 0x57, 'W');
			yield return new TestCaseData(Ascii.UpperX, 0x58, 'X');
			yield return new TestCaseData(Ascii.UpperY, 0x59, 'Y');
			yield return new TestCaseData(Ascii.UpperZ, 0x5A, 'Z');
			yield return new TestCaseData(Ascii.OpeningBracket, 0x5B, '[');
			yield return new TestCaseData(Ascii.Backslash, 0x5C, '\\');
			yield return new TestCaseData(Ascii.ClosingBracket, 0x5D, ']');
			yield return new TestCaseData(Ascii.Caret, 0x5E, '^');
			yield return new TestCaseData(Ascii.Underscore, 0x5F, '_');

			yield return new TestCaseData(Ascii.GraveAccent, 0x60, '`');
			yield return new TestCaseData(Ascii.LowerA, 0x61, 'a');
			yield return new TestCaseData(Ascii.LowerB, 0x62, 'b');
			yield return new TestCaseData(Ascii.LowerC, 0x63, 'c');
			yield return new TestCaseData(Ascii.LowerD, 0x64, 'd');
			yield return new TestCaseData(Ascii.LowerE, 0x65, 'e');
			yield return new TestCaseData(Ascii.LowerF, 0x66, 'f');
			yield return new TestCaseData(Ascii.LowerG, 0x67, 'g');
			yield return new TestCaseData(Ascii.LowerH, 0x68, 'h');
			yield return new TestCaseData(Ascii.LowerI, 0x69, 'i');
			yield return new TestCaseData(Ascii.LowerJ, 0x6A, 'j');
			yield return new TestCaseData(Ascii.LowerK, 0x6B, 'k');
			yield return new TestCaseData(Ascii.LowerL, 0x6C, 'l');
			yield return new TestCaseData(Ascii.LowerM, 0x6D, 'm');
			yield return new TestCaseData(Ascii.LowerN, 0x6E, 'n');
			yield return new TestCaseData(Ascii.LowerO, 0x6F, 'o');

			yield return new TestCaseData(Ascii.LowerP, 0x70, 'p');
			yield return new TestCaseData(Ascii.LowerQ, 0x71, 'q');
			yield return new TestCaseData(Ascii.LowerR, 0x72, 'r');
			yield return new TestCaseData(Ascii.LowerS, 0x73, 's');
			yield return new TestCaseData(Ascii.LowerT, 0x74, 't');
			yield return new TestCaseData(Ascii.LowerU, 0x75, 'u');
			yield return new TestCaseData(Ascii.LowerV, 0x76, 'v');
			yield return new TestCaseData(Ascii.LowerW, 0x77, 'w');
			yield return new TestCaseData(Ascii.LowerX, 0x78, 'x');
			yield return new TestCaseData(Ascii.LowerY, 0x79, 'y');
			yield return new TestCaseData(Ascii.LowerZ, 0x7A, 'z');
			yield return new TestCaseData(Ascii.OpeningBrace, 0x7B, '{');
			yield return new TestCaseData(Ascii.Pipe, 0x7C, '|');
			yield return new TestCaseData(Ascii.ClosingBrace, 0x7D, '}');
			yield return new TestCaseData(Ascii.Tilde, 0x7E, '~');
			yield return new TestCaseData(Ascii.Delete, 0x7F, null);
		}
		#endregion
	}
}