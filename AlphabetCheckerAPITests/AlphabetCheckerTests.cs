
using AlphabetCheckerAPI.Utilities.Contracts;
using AlphabetCheckerAPI.Utilities.Services;
using System.Security.Cryptography;

namespace AlphabetCheckerAPITests
{
    public class AlphabetCheckerTests
    {
        private IAlphabetCheckerService alphabetCheckerService;

        [SetUp]
        public void Setup()
        {
            alphabetCheckerService = new AlphabetCheckerService();
        }

        [TestCase("The quick brown fox jumps over the lazy dog.", true, TestName = "ContainsAllAlphabets_ReturnsTrue_ForPangram")]
        [TestCase("12!@#$%^&*() abcdefghijklmnopqrstuvwxyz", true, TestName = "ContainsAllAlphabets_IgnoresSpecialCharactersAndNumbers")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", true, TestName = "ContainsAllAlphabets_ReturnsTrue_ForCaseInsensitiveInput")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", true, TestName = "ContainsAllAlphabets_ReturnsTrue_ForAllLetters")]
        [TestCase("Hello World!", false, TestName = "ContainsAllAlphabets_ReturnsFalse_ForMissingLetters")]
        [TestCase("", false, TestName = "ContainsAllAlphabets_ReturnsFalse_ForEmptyString")]
        public void ContainsAllAlphabets_TestCases(string input, bool expectedResult)
        {
            // Act
            bool result = alphabetCheckerService.ContainsAllAlphabets(input);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}