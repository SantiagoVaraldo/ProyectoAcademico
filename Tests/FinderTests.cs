using System;
using Xunit;
using ExerciseOne;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;  
using Finder = ExerciseOne.Finder;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class FinderTests
    {

        [Fact]
        public void PositiveTest()
        {
            //Finder.Find:
            //Input = string -> html
            //Output = List<Tag> tags

            string input = @"<html>
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

            List<Tag> expectedTags = new List<Tag>();
            expectedTags.Add(new Tag("html"));
            expectedTags.Add(new Tag("body"));

            List<Attribute> fontAttributes1 = new List<Attribute>();
            fontAttributes1.Add(new Attribute("color", "blue"));
            fontAttributes1.Add(new Attribute("size", "3"));
            expectedTags.Add(new Tag("font", fontAttributes1));

            List<Attribute> inputAttributes = new List<Attribute>();
            inputAttributes.Add(new Attribute("type", "text"));
            inputAttributes.Add(new Attribute("name", "nombre"));
            inputAttributes.Add(new Attribute("maxlenght", "8"));
            expectedTags.Add(new Tag("input", inputAttributes));
            
            expectedTags.Add(new Tag("br"));

            List<Attribute> fontAttributes2 = new List<Attribute>();
            inputAttributes.Add(new Attribute("size", "2"));
            expectedTags.Add(new Tag("font",fontAttributes2));

            Finder finder = new Finder();
            List<Tag> results = finder.Find(input);

            //CollectionAssert.AreEqual(expectedTags, results);

        }
    }
}