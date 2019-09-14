using System;
using Xunit;
using ExerciseOne;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

using System.Net;

namespace Tests
{
    public class DownloaderTests
    {
        [Fact]
        public void CorrectDownload()
        {

            string expected = @"<html>
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
            const String fileName = @"..\..\..\..\src\Library\test.html";
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            UriBuilder builder = new UriBuilder("file", "", 0, path);
            String uri = builder.Uri.ToString();
            Downloader downloader = new Downloader(uri);
            string actual = downloader.Download();
            expected = expected.Replace(" ", "");
            actual = actual.Replace(" ", "");
            Assert.Equal(expected, actual);


        }
    }
}