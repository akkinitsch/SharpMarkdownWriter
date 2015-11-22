using NUnit.Framework;
using System;

namespace SharpMarkdownWriterLibTest
{
	[TestFixture ()]
	public class SharpMarkdownWriterTest
	{

		[Test()]
		public void getResultForHeadings_MaximumNumbersHeadingsRequested_ReturnsValidOutput()
		{
			SharpMarkdownWriterLib.SharpMarkdownWriter writer = new SharpMarkdownWriterLib.SharpMarkdownWriter ("test.md");
			for (int i = 1; i <= 5; i++) {
				writer.Heading ("bar", i);
			}
			StringAssert.Contains ("### bar", writer.getResult ());
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

