using NUnit.Framework;
using System.Collections.Generic;

namespace SharpMarkdownWriterTest
{
	[TestFixture]
	public class SharpMarkdownWriterTest
	{

		[Test]
		public void getResultForHeadings_MaximumNumbersHeadingsRequested_ReturnsValidOutput()
		{
			SharpMarkdownWriterLib.SharpMarkdownWriter writer = new SharpMarkdownWriterLib.SharpMarkdownWriter ("test.md");
			for (int i = 1; i <= 5; i++) {
				writer.Heading ("bar", i);
			}
			StringAssert.Contains ("### bar", writer.getResult ());
		}

		[Test]
		public void getResultFromTable_TableHeadingsAndContentGiven_WritesTableToFile()
		{
			List<string> headerList;
			List<List<string>> contentList;
			List<string> contentList1;
			List<string> contentList2;
			headerList = new List<string>();
			contentList = new List<List<string>>();
			contentList1 = new List<string> ();
			contentList2 = new List<string> ();
			headerList.Add ("heading1");
			headerList.Add ("heading2");
			headerList.Add ("heading3");
			contentList1.Add ("cell11");
			contentList1.Add ("cell12");
			contentList1.Add ("cell13");
			contentList2.Add ("cell21");
			contentList2.Add ("cell22");
			contentList2.Add ("cell23");
			contentList.Add (contentList1);
			contentList.Add (contentList2);
			SharpMarkdownWriterLib.SharpMarkdownWriter writer = new SharpMarkdownWriterLib.SharpMarkdownWriter ("test.md");
			writer.Table (headerList, "lcr", contentList);
			writer.Save ();
		}

		[Test]
		[Ignore("Exception is expected - NUnit 3 handles this another way")]
		public void getResultForHeadings_MoreThanMaximumNumbersHeadingsRequested_ThrowsMaximumNumberHeadingsException()
		{
			SharpMarkdownWriterLib.SharpMarkdownWriter writer = new SharpMarkdownWriterLib.SharpMarkdownWriter ("test.md");
			for (int i = 1; i <= 7; i++) {
				writer.Heading ("bar", i);
			}
		}

	}
	
}

