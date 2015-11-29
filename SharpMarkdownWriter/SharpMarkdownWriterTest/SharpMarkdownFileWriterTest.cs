using NUnit.Framework;

namespace SharpMarkdownWriterTest
{
	[TestFixture]
	public class SharpMarkdownFileWriterTest
	{
		[Test]
		public void saveMarkdownDocument_writeToValidFilePath_ReturnsTrue()
		{
			SharpMarkdownWriterLib.SharpMarkdownFileWriter fileWriter = new SharpMarkdownWriterLib.SharpMarkdownFileWriter("test.md");
			Assert.IsTrue(fileWriter.saveMarkdownDocument("test"));
		}

		[Test]
		public void saveMarkdownDocument_writeToInvalidFilePath_ReturnsTrue()
		{
			SharpMarkdownWriterLib.SharpMarkdownFileWriter fileWriter = new SharpMarkdownWriterLib.SharpMarkdownFileWriter("/");
			Assert.IsFalse(fileWriter.saveMarkdownDocument("test"));
		}
	}
}

