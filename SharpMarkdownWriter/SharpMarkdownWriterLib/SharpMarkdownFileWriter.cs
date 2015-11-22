using System;
using System.IO;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownFileWriter
	{
		private string outputFile;

		public SharpMarkdownFileWriter (string fileName)
		{
			this.outputFile = fileName;
		}

		public bool saveMarkdownDocument(string text)
		{
			try
			{
				System.IO.TextWriter writeFile = new StreamWriter(this.outputFile);
				writeFile.Write(text);
				writeFile.Flush();
				writeFile.Close();
				return true;
			}
			catch (IOException)
			{
				return false;
			}
			catch(System.UnauthorizedAccessException)
			{
				return false;
			}
		}
	}
}

