using AlphabetCheckerAPI.Utilities.Contracts;
using AlphabetCheckerAPI.Utilities.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlphabetCheckerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlphabetCheckerController : ControllerBase
    {
        private readonly IAlphabetCheckerService _alphabetCheckerService;

        public AlphabetCheckerController(IAlphabetCheckerService alphabetCheckerService)
        {
            _alphabetCheckerService = alphabetCheckerService;
        }

        [HttpPost("CheckAlphabetPresence")]
        public IActionResult CheckAlphabetPresence([FromBody] string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            bool allLettersPresent = _alphabetCheckerService.ContainsAllAlphabets(input);

            return Ok(new { containsAllAlphabets = allLettersPresent });
        }
    }
}
