using Xunit;
using Attribute = ExerciseOne.Attribute;

namespace Tests
{
    public class AttributeTests
    {

        [Fact]
        public void InvalidKey()
        {
            string expected = null;
            string value = "nombre";
            Attribute attribute = new Attribute("", value);
            Assert.Equal(attribute.Key, expected);
        }

        [Fact]
        public void InvalidValue()
        {
            string expected = null;
            string key = "key";
            Attribute attribute = new Attribute(key, "");
            Assert.Equal(attribute.Value, expected);
        }
        [Fact]
        public void ValidValueAndkey()
        {
            string ClaveExpected = "color";
            string ValorExpected = "rojo";
            Attribute attribute = new Attribute("color", "rojo");
            Assert.Equal(attribute.Value, ValorExpected);
            Assert.Equal(attribute.Key, ClaveExpected);
        }
        [Fact]
        public void InvalidKeyAndValue()
        {
            string ClaveExpected = null;
            string ValorExpected = null;
            Attribute attribute = new Attribute("", "");
            Assert.Equal(attribute.Value, ValorExpected);
            Assert.Equal(attribute.Key, ClaveExpected);
        }
    }
}