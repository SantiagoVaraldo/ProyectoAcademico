using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;

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
                  [Fact]
                  public void CorrectOperationOfTheMethodDownload()
                  {
                           string url =@"..\..\..\..\Library\test.html";
                           Downloader downloader = new Downloader(url);
                           string inputExpected = @"<html>
	                            <body>
		                            <font color=""blue"" size=""3"">
			                            Ingrese su nombre 
		                            </font>
		                            <input type=""text"" name=""nombre"" maxlength=""8""/>
		                            <br/>
		                            <font size=""2"">
			                            Máximo 8caracteres
		                            </font>
	                            </body>
                            </html>";
                           string result = downloader.Download();
                           Assert.Equal(result,inputExpected);
                  }
         }
}
