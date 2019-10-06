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

                    if (resultTags[i].ListaAtributos != null & expectedTags[i].ListaAtributos != null)
                    {
                        Assert.Equal(resultTags[i].ListaAtributos.Count, expectedTags[i].ListaAtributos.Count);

                        if (resultTags[i].ListaAtributos.Count > 0 & expectedTags[i].ListaAtributos.Count > 0 &
                            resultTags[i].ListaAtributos.Count == expectedTags[i].ListaAtributos.Count)
                        {
                            for (int j = 0; j < resultTags[i].ListaAtributos.Count; j++)
                            {
                                Assert.Equal(resultTags[i].ListaAtributos[j.ToString()].Clave, expectedTags[i].ListaAtributos[j.ToString()].Clave);
                                Assert.Equal(resultTags[i].ListaAtributos[j.ToString()].Valor, expectedTags[i].ListaAtributos[j.ToString()].Valor);
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

            Dictionary<string ,Attribute> fontAttributes1 = new Dictionary<string, Attribute>();
            Attribute attribute1 = new Attribute("color","blue");
            Attribute attribute2 = new Attribute("size","3");
            fontAttributes1.Add(attribute1.Clave,attribute1);
            fontAttributes1.Add(attribute2.Clave,attribute2);
            expectedTags.Add(new Tag("font", fontAttributes1));

            Dictionary<string, Attribute> inputAttributes = new Dictionary<string, Attribute>();
            Attribute attribute3 = new Attribute("type", "text");
            Attribute attribute4 = new Attribute("name", "nombre");
            Attribute attribute5 = new Attribute("maxlength", "8");
            inputAttributes.Add(attribute3.Clave,attribute3);
            inputAttributes.Add(attribute4.Clave,attribute4);
            inputAttributes.Add(attribute5.Clave,attribute5);
            expectedTags.Add(new Tag("input", inputAttributes));

            expectedTags.Add(new Tag("br"));

            Dictionary<string,Attribute> fontAttributes2 = new Dictionary<string,Attribute>();
            Attribute attribute6 = new Attribute("size", "2");
            fontAttributes2.Add(attribute6.Clave,attribute6);
            expectedTags.Add(new Tag("font", fontAttributes2));
            FinderTests.ComparatorMethod(input, expectedTags);
        }

        [Fact]
        public void BadlyFormatedHTMLTest()
        {
            //Finder.Find:
            //Input = string -> html
            //Output = List<Tag> tags

            string input = @"<font color=""blue"" size=""3"">Ingrese su nombre 
                             <input type=""text"" name=""nombre"" maxlength=""8"">
                             <br>
                             <font size=""2"">Máximo 8 caracteres";

            List<Tag> expectedTags = new List<Tag>();

            Dictionary<string, Attribute> fontAttributes1 = new Dictionary<string, Attribute>();
            Attribute attribute = new Attribute("color", "blue");
            Attribute attribute1 = new Attribute("size", "3");
            fontAttributes1.Add(attribute.Clave,attribute);
            fontAttributes1.Add(attribute1.Clave,attribute1);
            expectedTags.Add(new Tag("font", fontAttributes1));

            Dictionary<string, Attribute> inputAttributes = new Dictionary<string, Attribute>();
            Attribute attribute2 = new Attribute("type", "text");
            Attribute attribute3 = new Attribute("name", "nombre");
            Attribute attribute4 = new Attribute("maxlength", "8");
            inputAttributes.Add(attribute2.Clave,attribute2);
            inputAttributes.Add(attribute3.Clave,attribute3);
            inputAttributes.Add(attribute4.Clave,attribute4);
            expectedTags.Add(new Tag("input", inputAttributes));

            expectedTags.Add(new Tag("br"));

            Dictionary<string, Attribute> fontAttributes2 = new Dictionary<string, Attribute>();
            Attribute attribute5 = new Attribute("type", "text");
            fontAttributes2.Add(attribute5.Clave,attribute5);
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