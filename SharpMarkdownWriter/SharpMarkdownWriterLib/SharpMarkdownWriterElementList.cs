using System;
using System.Collections.Generic;

namespace SharpMarkdownWriterLib
{
	public class SharpMarkdownWriterElementList
	{
		public List<Object> listElements;

		public SharpMarkdownWriterElementList ()
		{
			listElements = new List<Object>();
		}

		public void add(Object o)
		{
			listElements.Add(o);
		}

		public int Count()
		{
			return listElements.Count;
		}
	}
}

