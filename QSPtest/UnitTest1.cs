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

        [TestMethod]
        public void ParseQueryString_Count_Empty_Test()
        {
            // Arrange
            string input = ""; // Tom query-streng
            int expected = 0; // Forventet resultat for tom input

            // Act
            var result = parser.CountPairs(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseQueryString_Count_Null_Test()
        {
            // Arrange
            string input = null; // Null query-streng
            int expected = 0; // Forventet resultat for null input

            // Act
            var result = parser.CountPairs(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ParseQueryString_ValueOf_Test()
        {
            // Arrange
            string input = "name=value";
            string key = "name";
            string expectedValue = "value";

            // Act
            var result = parser.ValueOf(input, key);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ParseQueryString_ValueOf_NonExistent_Key_Test()
        {
            // Arrange
            string input = "name=value";
            string key = "age"; // Nøgle, der ikke findes
            string expectedValue = null;

            // Act
            var result = parser.ValueOf(input, key);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ParseQueryString_Count_Multiple_Test()
        {
            // Arrange
            string input = "name=value&age=30&city=London"; // Flere key-value par
            int expected = 3; // Forventet antal par

            // Act
            var result = parser.CountPairs(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        

        
        
    }
}
