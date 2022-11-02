using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using SunnyvaleNailBar.Models;

namespace SunnyvaleNailBar.Controllers
{
    public class BookingController : Controller
    {

        public ActionResult Booking(string Name,
            string Phone,
            string Email,
            string Date,
            string FirstVisit,
            string Time,
            string Service1,
            string Service2,
            string Service3,
            string QuantityService1,
            string QuantityService2,
            string QuantityService3,
            string Comment
            )
        {
            SysJMessage.JMessage msg = new SysJMessage.JMessage();

           
            return Json(msg);
        }
    }
}