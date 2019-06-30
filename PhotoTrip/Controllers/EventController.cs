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
            Ok("It's the first event");
    }
}
