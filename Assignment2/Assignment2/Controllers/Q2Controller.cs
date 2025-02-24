using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Checks if the given date is before, after, or on February 18.
        /// </summary>
        /// <param name="month">Month as an integer (1-12).</param>
        /// <param name="day">Day as an integer (1-31).</param>
        /// <returns>Returns "Before", "After", or "Special".</returns>
        /// <example>
        /// GET /api/J1/SpecialDay?month=2&day=18
        /// Response: "Special"
        /// </example>
        [HttpGet("SpecialDay")]
        public IActionResult CheckSpecialDay([FromQuery] int month, [FromQuery] int day)
        {
            if (month < 2 || (month == 2 && day < 18))
                return Ok("Before");
            else if (month == 2 && day == 18)
                return Ok("Special");
            else
                return Ok("After");
        }
    }
}
