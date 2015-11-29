using System.Collections.Generic;
using NUnit.Framework;
using SharpMarkdownWriterLib;

namespace SharpMarkdownWriterTest
{
	[TestFixture]
	public class SharpMarkdownWriterOrderedListTest
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

		const string oNeTwoThree = "\n1. one\n2. two\n3. three\n";

		[Test]
		public void getResultOrderedList_listContentGiven_ReturnsList()
		{
			SharpMarkdownWriterOrderedList list = new SharpMarkdownWriterOrderedList(inputList);
			string result = list.ToString ();
			Assert.IsTrue(result == oNeTwoThree);
		}}
}

