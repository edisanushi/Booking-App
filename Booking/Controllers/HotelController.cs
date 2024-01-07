using System;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
	public class HotelController: Controller
	{
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HotelBooking()
        {
            return View();
        }


        [HttpGet]
        public IActionResult HotelChain()
        {
            return View();
        }

   
        public IActionResult RoomDetail()
        {
            return View();
        }
        public IActionResult Resort()
        {
            return View();
        }
        public IActionResult HotelDetail()
        {
            return View();
        }
        public IActionResult HotelGrid()
        {
            return View();
        }
        public IActionResult HotelList()
        {
            return View();
        }




    }

}




