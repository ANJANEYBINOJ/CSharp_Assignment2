using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the final score for the Deliv-e-droid game.
        /// </summary>
        /// <param name="collisions">The number of collisions with obstacles.</param>
        /// <param name="deliveries">The number of packages delivered.</param>
        /// <returns>The final score.</returns>
        /// <example>
        /// POST /api/J1/Delivedroid
        /// Body: Collisions=2&Deliveries=5
        /// Response: 730
        /// </example>
        [HttpPost("Delivedroid")]
        public int CalculateScore([FromForm] int collisions, [FromForm] int deliveries)
        {
            int score = (deliveries * 50) - (collisions * 10);
            if (deliveries > collisions)
            {
                score += 500;
            }
            return score;
        }
    }
}



