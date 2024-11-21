using AlphabetCheckerAPI.Utilities.Contracts;

namespace AlphabetCheckerAPI.Utilities.Services
{
    public class AlphabetCheckerService : IAlphabetCheckerService
    {
        public bool ContainsAllAlphabets(string input)
        {
            string text = input.ToLower();
            HashSet<char> uniqueLetters = [];

            // Add each letter to the HashSet
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    uniqueLetters.Add(c);
                }

                // Break early if all 26 letters are found
                if (uniqueLetters.Count == 26)
                {
                    return true;
                }
            }

            // Check if all 26 letters were found
            return uniqueLetters.Count == 26;
        }
    }
}
