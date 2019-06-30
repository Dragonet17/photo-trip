using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PhotoTrip.Controllers
{
    public class EventController : BaseController
    {
        /// <summary>
        /// Przykład użycia routingu
        /// </summary>
        /// <returns>Testowy opis</returns>
        [HttpGet("event")]
        public IActionResult Event() =>
            Ok(new {Name = "Karol" });

        /// <summary>
        /// Get event by id
        /// </summary>
        /// <param name="id">event id</param>
        /// <returns>Eevent object</returns>
        [HttpGet("event/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetEvent(int id) =>
            Ok("It's the first event");
    }
}
