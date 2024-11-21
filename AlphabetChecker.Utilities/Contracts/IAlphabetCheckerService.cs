namespace AlphabetCheckerAPI.Utilities.Contracts
{
    public interface IAlphabetCheckerService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        bool ContainsAllAlphabets(string input);
    }
}
