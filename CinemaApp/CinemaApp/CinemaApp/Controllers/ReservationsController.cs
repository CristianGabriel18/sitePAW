using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CinemaApp.Controllers
{
    public class ReservationsController : Controller
    {

        public IActionResult ListOfSeats()
        {
            return View();
        }
    }
}
