using System;
using System.IO;
using Xunit;
using Library;
using ExerciseOne;
using System.Reflection;
using System.Collections.Generic;

namespace Tests
{
    public class CreateElementTests
    {
        [Fact]
        public void PositiveTest()
        {
            string contenido = @"<World Name=""TheWorld"" Length=""50"" Width=""50"">
	                                <Level Name=""Level2"" World=""TheWorld"">
		                                <Screen Name=""Screen1"" level=""Level2"">
			                                <Image Name=""CowImage"" Posicion_y=""-25"" Posicion_x=""-25"" Length=""10"" Width=""10"" Screen=""Screen1"" Imagepath="""">
			                                </Image>
			                                <Button Name=""CowImage"" Posicion_y=""-25"" Posicion_x=""-25"" Length=""10"" Width=""10"" Screen=""Screen1"" Imagepath="""">
			                                </Button>
		                                </Screen>
	                                </Level>
                                </World>";

            List<Screen> listScreen = new List<Screen>();
            List<Element> listElements = new List<Element>();
            List<Level> listLevels = new List<Level>();
            World world;
            world = new World("TheWorld", 50, 50);
            listLevels.Add(new Level("Level2", "TheWorld"));
            listScreen.Add(new Screen("Screen1", "Level2"));
            listElements.Add(new Image("CowImage", -25, -25, 10, 10, "Screen1", ""));
            listElements.Add(new Button("CowImage", -25, -25, 10, 10, "Screen1", ""));
            List<object> actual = new List<object>();
            actual.Add(world);
            actual.Add(listLevels);
            actual.Add(listScreen);
            actual.Add(listElements);
            Finder finder = new Finder();
            List<Tag> tags = finder.Find(contenido);
            CreateElements elements = new CreateElements();
            List<object> expected = new List<object>();
            expected = elements.Create(tags);
            Assert.Equal(actual, expected);






        }
    }
}
