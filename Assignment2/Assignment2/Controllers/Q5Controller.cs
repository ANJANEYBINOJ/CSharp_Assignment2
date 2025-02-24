using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment2.Controllers
{
    [Route("api/J3")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Converts a list of 3-digit numbers into movement instructions.
        /// </summary>
        /// <param name="instructions">Comma-separated list of 3-digit numbers.</param>
        /// <returns>A list of movement instructions.</returns>
        /// <example>
        /// GET /api/J3/SecretInstructions?instructions=123,256,098,123
        /// Response: ["Left 23", "Right 56", "STOP"]
        /// </example>
        [HttpGet("SecretInstructions")]
        public IActionResult GetSecretInstructions([FromQuery] string instructions)
        {
            if (string.IsNullOrWhiteSpace(instructions)) return BadRequest("Instructions cannot be empty.");

            string[] inputNumbers = instructions.Split(',');
            List<string> output = new List<string>();

            foreach (var number in inputNumbers)
            {
                int num = int.Parse(number);
                if (num / 100 == 0) { output.Add("STOP"); break; }
                else if (num / 100 == 1) output.Add($"Left {num % 100}");
                else if (num / 100 == 2) output.Add($"Right {num % 100}");
            }

            return Ok(output);
        }
    }
}
