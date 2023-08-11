using Microsoft.AspNetCore.Mvc;
using MWAppSolutions.Algorithms.ArrayTraversal;

namespace MW.AppSolutions.DataStructuresAndAlgorithms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArrayTraversalController : ControllerBase
    {

        private readonly ILogger<ArrayTraversalController> _logger;

        public ArrayTraversalController(ILogger<ArrayTraversalController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Tests if a string's letters and numbers are a valid palindrome.
        /// Ignores all whitespace, and special characters.
        /// Leetcode #125
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>Boolean value for result of test</returns>
        [HttpGet("/ValidPalindrome/{testString}")]
        public bool ValidPalindrome(string testString)
        {
            var result = TwoPointers.ValidPalindrome(testString);
            _logger.LogInformation($"Passing {testString} to {nameof(TwoPointers.ValidPalindrome)}, with result: {result}");
            return result;
        }

        /// <summary>
        /// Tests is the substring exists in in the test string. 
        /// Leetcode #392
        /// </summary>
        /// <param name="testString"></param>
        /// <returns></returns>
        [HttpGet("/ContainsSubstring/{testString}/{subString}")]
        public bool ContainsSubstring(string testString, string subString)
        {
            var result = TwoPointers.IsSubsequence(testString, subString);
            _logger.LogInformation($"Passing {testString} to {nameof(TwoPointers.IsSubsequence)}, with result: {result}");
            return result;
        }
    }
}