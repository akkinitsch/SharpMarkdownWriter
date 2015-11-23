using System;
using System.Collections.Generic;
using System.Text;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownWriterTable
	{
		private StringBuilder stringBuilder;
		private int numberOfRows = 0;


		public SharpMarkdownWriterTable ()
		{
			stringBuilder = new StringBuilder ();
		}

		public SharpMarkdownWriterTable(List<string> headings, List<List<string>> content)
		{
			this.numberOfRows = headings.Count;
			stringBuilder = new StringBuilder ();
			stringBuilder.Append(BuildHeader (headings));
			stringBuilder.Append (BuildContent (content));
		}

		public string BuildHeader(List<string> headings)
		{
			StringBuilder result = new StringBuilder ();
			result.Append ("|");
			foreach (string cellContent in headings)
			{
				result.Append(cellContent);
				result.Append ("|");
			}
			result.AppendLine();
			result.Append ("|");
			foreach (string cellContent in headings)
			{
				for (int x = 0; x < cellContent.Length; x++)
				{
					result.Append ("-");
				}
				result.Append ("|");
			}
			result.AppendLine ();
			return result.ToString ();
		}

		public string BuildContent(List<List<string>> content)
		{
			int rowCounter;
			StringBuilder result = new StringBuilder ();
			foreach (List<string> row in content)
			{
				rowCounter = 0;
				result.Append ("|");
				foreach (string cell in row)
				{
					result.Append (cell);
					result.Append("|");
					rowCounter++;
				}
				for (int i=0; i<numberOfRows-rowCounter; i++)
				{
					result.Append(" |");
				}
				result.Append("\n");
			}
			return result.ToString ();
		}

		public override string ToString()
		{
			return this.stringBuilder.ToString ();
		}
	}
}

