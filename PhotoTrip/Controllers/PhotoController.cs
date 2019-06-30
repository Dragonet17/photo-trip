using Microsoft.AspNetCore.Mvc;

namespace PhotoTrip.Controllers
{
    public class PhotoController : BaseController
    {
        /// <summary>
        /// Przykład użycia routingu
        /// </summary>
        /// <returns>Testowy opis</returns>
        [HttpGet]
        public IActionResult Get() =>
            Ok(new { Name = "Cichoń" });
    }
}
