using Xunit;
using ExerciseOne;

namespace Tests
{
         public class DownloadTests
         {
                  [Fact]
                  public void CorrectCreationDownloader()
                  {
                           Downloader downloader = new Downloader(@"..\..\..\..\Library\test.html");
                           string urlExpected = @"..\..\..\..\Library\test.html";
                           Assert.Equal(urlExpected,downloader.Url);
                  }
         }
}
