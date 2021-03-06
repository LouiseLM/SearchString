using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchString;

namespace TestSearchString
{
    [TestClass]
    public class UtilitiesTests
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            var stringToCheck = "mysterious";

            var stringToFind = "y";

            var expectedResult = 1;

            var classUnderTest = new StringUtilities();

            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            var stringToCheck = "mysterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SearchShouldBeCaseSenstive()
        {
            var stringToCheck = "mySterious";
            var stringToFind = "s";
            var expectedResult = 2;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            var stringToFind = "s";
            var expectedResult = -1;
            var classUnderTest = new StringUtilities();
            var actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
