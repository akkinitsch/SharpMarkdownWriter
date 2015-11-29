using System;
using System.IO;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownFileWriter
	{
		private string outputFile;

		public SharpMarkdownFileWriter (string fileName)
		{
			outputFile = fileName;
		}

		public bool saveMarkdownDocument(string text)
		{
			try
			{
				TextWriter writeFile = new StreamWriter(outputFile);
				writeFile.Write(text);
				writeFile.Flush();
				writeFile.Close();
				return true;
			}
			catch (IOException)
			{
				return false;
			}
			catch(UnauthorizedAccessException)
			{
				return false;
			}
		}
	}
}

