using System.Collections.Generic;
using NUnit.Framework;
using SharpMarkdownWriterLib;

namespace SharpMarkdownWriterTest
{
	[TestFixture]
	public class SharpMarkdownWriterUnorderedListTest
	{
		List<string> inputList;

		[SetUp]
		public void setup()
		{
			inputList = new List<string> ();
			inputList.Add ("one");
			inputList.Add ("two");
			inputList.Add ("three");
		}

		const string oNeTwoThree = "\n* one\n* two\n* three\n";

		[Test]
		public void getResultUnorderedList_listContentGiven_ReturnsList()
		{
			SharpMarkdownWriterUnorderedList list = new SharpMarkdownWriterUnorderedList(inputList);
			string result = list.ToString ();
			Assert.IsTrue(result == oNeTwoThree);
		}}
}

