using System.Collections.Generic;
using System.Text;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownWriterUnorderedList : SharpMarkdownWriterElement
	{

		public SharpMarkdownWriterUnorderedList (List<string> input)
		{
			stringBuilder = new StringBuilder ();
			stringBuilder.AppendLine ();
			foreach (string entry in input)
			{
				stringBuilder.AppendLine ("* " + entry);
			}
		}
	}
}

