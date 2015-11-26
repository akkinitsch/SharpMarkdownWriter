using System;
using System.Text;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownWriter
	{
		private SharpMarkdownWriterElementList list;
		private static StringBuilder builder;
		private readonly SharpMarkdownFileWriter fileWriter;

		public SharpMarkdownWriter (string outputFileName)
		{
			list = new SharpMarkdownWriterElementList ();
			builder = new StringBuilder ();
			fileWriter = new SharpMarkdownFileWriter (outputFileName);
		}

		public void Heading(string text, int bla)
		{
			if (bla > 5)
			{
				throw new NumberMaximumHeadingsReachedException ();
			}
				
			builder = new StringBuilder ();
			for (int i = 0; i < bla; i++)
			{
				builder.Append ("#");
			}
			builder.Append (" " + text);
			list.add(builder);
		}

	    public void Paragraph(string text)
	    {
	        builder = new StringBuilder();
	        builder.AppendLine(text);
            list.add(builder);
	    }

		public void Table(System.Collections.Generic.List<string> headings, System.Collections.Generic.List<System.Collections.Generic.List<string>> content)
		{
			list.add (new SharpMarkdownWriterTable(headings, content));
		}

		public void Table(System.Collections.Generic.List<string> headings, string alignment, System.Collections.Generic.List<System.Collections.Generic.List<string>> content)
		{
			list.add (new SharpMarkdownWriterTable(headings, alignment, content));
		}

		public string getResult()
		{
			builder = new StringBuilder ();
			for (int i = 0; i < list.Count (); i++)
			{
				builder.AppendLine (list.listElements[i].ToString());
			}
			return builder.ToString ();
		}

		public bool Save()
		{
			return fileWriter.saveMarkdownDocument (getResult ());
		}
	

	public class NumberMaximumHeadingsReachedException : Exception
	{
		public override string Message
		{
			get
			{
				return "This exception means something bad happened";
			}
		}
	}
}
}