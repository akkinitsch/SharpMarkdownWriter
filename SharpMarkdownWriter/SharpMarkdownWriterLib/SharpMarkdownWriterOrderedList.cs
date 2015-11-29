using System.Collections.Generic;
using System.Text;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownWriterOrderedList : SharpMarkdownWriterElement
	{

		public SharpMarkdownWriterOrderedList (List<string> input)
		{
			int i = 1;
			stringBuilder = new StringBuilder ();
			stringBuilder.AppendLine ();
			foreach (string entry in input)
			{
				stringBuilder.AppendLine (i + ". " + entry);
				stringBuilder.AppendLine (i + ". " + entry);
				i++;
			}
		}
	}
}

