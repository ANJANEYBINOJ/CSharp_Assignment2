using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/J2")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Counts the number of cars that remained parked in the same spot.
        /// </summary>
        /// <param name="yesterday">String representing the parking lot yesterday.</param>
        /// <param name="today">String representing the parking lot today.</param>
        /// <returns>Number of cars that remained in the same spot.</returns>
        /// <example>
        /// GET /api/J2/OccupyParking?yesterday=C.CC.&today=C..CC
        /// Response: 2
        /// </example>
        [HttpGet("OccupyParking")]
        public IActionResult CountSameParkingCars([FromQuery] string yesterday, [FromQuery] string today)
        {
            if (yesterday.Length != today.Length) return BadRequest("Invalid input.");

            int count = 0;
            for (int i = 0; i < yesterday.Length; i++)
                if (yesterday[i] == 'C' && today[i] == 'C') count++;

            return Ok(count);
        }
    }
}

