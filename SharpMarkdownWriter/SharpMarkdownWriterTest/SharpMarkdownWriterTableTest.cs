using NUnit.Framework;
using System.Collections.Generic;

namespace SharpMarkdownWriterTest
{
	[TestFixture]
	public class SharpMarkdownWriterTableTest
	{
		List<string> headerList;
		List<List<string>> contentList;
		List<string> contentList1;
		List<string> contentList2;

		[SetUp]
		public void Setup ()
		{
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
		}

		[Test]
		public void BuildHeader_GenerateHeadingWithoutFormating_ReturnsTableHeader()
		{
			SharpMarkdownWriterLib.SharpMarkdownWriterTable writerTable = new SharpMarkdownWriterLib.SharpMarkdownWriterTable(headerList, contentList);
			string result = writerTable.BuildHeader(headerList);
			StringAssert.AreEqualIgnoringCase ("|heading1|heading2|heading3|\n|--------|--------|--------|\n", result);
		}

		[Test]
		public void getResultFromTable_GenerateContent_ReturnsRowContent()
		{
			SharpMarkdownWriterLib.SharpMarkdownWriterTable writerTable = new SharpMarkdownWriterLib.SharpMarkdownWriterTable(headerList, contentList);
			string result = writerTable.BuildContent(contentList);
			StringAssert.AreEqualIgnoringCase ("|cell11|cell12|cell13|\n|cell21|cell22|cell23|\n", result);
		}

		[Test]
		public void getResultFromTable_LastRowToShort_ReturnsRowContent()
		{
			contentList2 = new List<string> ();
			contentList = new List<List<string>> ();
			contentList2.Add ("cell21");
			contentList.Add (contentList1);
			contentList.Add (contentList2);
			SharpMarkdownWriterLib.SharpMarkdownWriterTable writerTable = new SharpMarkdownWriterLib.SharpMarkdownWriterTable(headerList, contentList);
			string result = writerTable.BuildContent(contentList);
			StringAssert.AreEqualIgnoringCase ("|cell11|cell12|cell13|\n|cell21| | |\n", result);
		}

		[Test]
		public void getResultFromTable_GenerateHeadingAndContent_ReturnsWholeTable()
		{
			SharpMarkdownWriterLib.SharpMarkdownWriterTable writerTable = new SharpMarkdownWriterLib.SharpMarkdownWriterTable(headerList, contentList);
			StringAssert.AreEqualIgnoringCase ("|heading1|heading2|heading3|\n|--------|--------|--------|\n|cell11|cell12|cell13|\n|cell21|cell22|cell23|\n", writerTable.ToString());
		}

		[Test]
		public void getResultFromTable_GenerateHeadingAndContentWithAlignment_ReturnsWholeTable()
		{	string alignment = "lcr";
			SharpMarkdownWriterLib.SharpMarkdownWriterTable writerTable = new SharpMarkdownWriterLib.SharpMarkdownWriterTable(headerList, alignment, contentList);
			StringAssert.AreEqualIgnoringCase ("|heading1|heading2|heading3|\n|--------|:------:|-------:|\n|cell11|cell12|cell13|\n|cell21|cell22|cell23|\n", writerTable.ToString());
		}
	}
}

