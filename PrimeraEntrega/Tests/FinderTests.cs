using Xunit;
using ExerciseOne;
using System.Collections.Generic;
using Finder = ExerciseOne.Finder;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class FinderTests
    {
        // metodo utilizado por todos los tests, compara los elementos de la List<> expectedTags con los elementos
        // de la lista que resulta de aplicar el metodo Finder
        public static void ComparatorMethod(string input, List<Tag> expectedTags)
        {
            Finder finder = new Finder();
            List<Tag> resultTags = finder.Find(input);

            Assert.Equal(expectedTags.Count, resultTags.Count);

            if (expectedTags.Count == resultTags.Count)
            {
                for (int i = 0; i < resultTags.Count; i++)
                {
                    Assert.Equal(resultTags[i].Name, expectedTags[i].Name);

                    if (resultTags[i].AttributeList != null & expectedTags[i].AttributeList != null)
                    {
                        Assert.Equal(resultTags[i].AttributeList.Count, expectedTags[i].AttributeList.Count);

                        if (resultTags[i].AttributeList.Count > 0 & expectedTags[i].AttributeList.Count > 0 &
                            resultTags[i].AttributeList.Count == expectedTags[i].AttributeList.Count)
                        {
                            foreach (KeyValuePair<string, Attribute> entry in resultTags[i].AttributeList)
                            {
                                //entry.key
                                //resultTags[i].AttributeList[entry.key]
                                bool encontro;
                                try
                                {
                                    Attribute attribute = expectedTags[i].AttributeList[entry.Key];
                                    encontro = true;
                                }
                                catch (System.Exception)
                                {
                                    encontro = false;
                                }
                                Assert.True(encontro);
                            }
                        }
                    }
                }
            }
        }

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

            Dictionary<string, Attribute> fontAttributes1 = new Dictionary<string, Attribute>();
            Attribute attribute1 = new Attribute("color", "blue");
            Attribute attribute2 = new Attribute("size", "3");
            fontAttributes1.Add(attribute1.Key, attribute1);
            fontAttributes1.Add(attribute2.Key, attribute2);
            expectedTags.Add(new Tag("font", fontAttributes1));

            Dictionary<string, Attribute> inputAttributes = new Dictionary<string, Attribute>();
            Attribute attribute3 = new Attribute("type", "text");
            Attribute attribute4 = new Attribute("name", "nombre");
            Attribute attribute5 = new Attribute("maxlength", "8");
            inputAttributes.Add(attribute3.Key, attribute3);
            inputAttributes.Add(attribute4.Key, attribute4);
            inputAttributes.Add(attribute5.Key, attribute5);
            expectedTags.Add(new Tag("input", inputAttributes));

            expectedTags.Add(new Tag("br"));

            Dictionary<string, Attribute> fontAttributes2 = new Dictionary<string, Attribute>();
            Attribute attribute6 = new Attribute("size", "2");
            fontAttributes2.Add(attribute6.Key, attribute6);
            expectedTags.Add(new Tag("font", fontAttributes2));
            FinderTests.ComparatorMethod(input, expectedTags);
        }

        [Fact]
        public void NoTagsTest()
        {
            //Finder.Find:
            //Input = string -> html
            //Output = List<Tag> tags

            string input = @"<html>
	                            <body>
		                            <font>
			                            Ingrese su nombre 
		                            </font>
		                            <input/>
		                            <br/>
		                            <font>
			                            Máximo 8caracteres
		                            </font>
	                            </body>
                            </html>";

            List<Tag> expectedTags = new List<Tag>();

            expectedTags.Add(new Tag("html"));
            expectedTags.Add(new Tag("body"));
            expectedTags.Add(new Tag("font"));
            expectedTags.Add(new Tag("input"));
            expectedTags.Add(new Tag("br"));
            expectedTags.Add(new Tag("font"));
            FinderTests.ComparatorMethod(input, expectedTags);
        }

        [Fact]
        public void NoInputTest()
        {
            //Finder.Find:
            //Input = string -> html
            //Output = List<Tag> tags

            string input = @"";

            List<Tag> expectedTags = new List<Tag>();

            FinderTests.ComparatorMethod(input, expectedTags);
        }
    }
}