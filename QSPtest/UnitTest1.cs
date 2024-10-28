using Microsoft.VisualStudio.TestTools.UnitTesting;
using QSParsingConsoleApp; 
namespace QSPtest // Fjernet semikolon - det er åbenbart vigtigt :u)
{
    [TestClass]
    public class QSParserTests
    {
        private QSParser parser;

        [TestInitialize]
        public void TestInitialize()
        {
            parser = new QSParser();
        }

        [TestMethod]
        public void ParseQueryString_Count_Name_Test()
        {
            // Arrange
            string input = "name=value";
            int expected = 1;

            // Act
            var result = parser.Count(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
