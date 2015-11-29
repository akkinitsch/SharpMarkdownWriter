using System.Text;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownWriterElement
	{
		public StringBuilder stringBuilder; 

		public override string ToString()
		{
			return stringBuilder.ToString ();
		}
	}
}

