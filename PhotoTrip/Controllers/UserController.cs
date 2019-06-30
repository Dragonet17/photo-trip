using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoTrip.Controllers
{
    public class UserController: BaseController
    {
        /// <summary>
        /// Przykład użycia routingu
        /// </summary>
        /// <returns>Testowy opis</returns>
        [HttpGet]
        public IActionResult Get() =>
            Ok(new { Login = "Karol", Surname = "Cichoń" });
    }
}
