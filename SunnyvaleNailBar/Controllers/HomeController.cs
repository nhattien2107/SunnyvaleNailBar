using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunnyvaleNailBar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Specials()
        {
            return View();
        }

        public ActionResult Booking()
        {

            ViewBag.FirstVisit = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "First Visit?", Value = "0"},
                    new SelectListItem { Text = "Yes", Value = "Yes"},
                    new SelectListItem { Text = "No", Value = "No"},
                }, "Value", "Text");

            ViewBag.Time = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "Choose Time", Value = "0"},
                    new SelectListItem { Text = "9:00 AM", Value = "900"},
                    new SelectListItem { Text = "9:30 AM", Value = "930"},
                    new SelectListItem { Text = "10:00 AM", Value = "1000"},
                    new SelectListItem { Text = "10:30 AM", Value = "1030"},
                    new SelectListItem { Text = "11:00 AM", Value = "1100"},
                    new SelectListItem { Text = "11:30 AM", Value = "1130"},
                    new SelectListItem { Text = "12:00 PM", Value = "1200"},
                    new SelectListItem { Text = "12:30 PM", Value = "1230"},
                    new SelectListItem { Text = "1:00 PM", Value = "100"},
                    new SelectListItem { Text = "1:30 PM", Value = "130"},
                    new SelectListItem { Text = "2:00 PM", Value = "200"},
                    new SelectListItem { Text = "2:30 PM", Value = "230"},
                    new SelectListItem { Text = "3:00 PM", Value = "300"},
                    new SelectListItem { Text = "3:30 PM", Value = "330"},
                    new SelectListItem { Text = "4:00 PM", Value = "400"},
                    new SelectListItem { Text = "4:30 PM", Value = "430"},
                    new SelectListItem { Text = "5:00 PM", Value = "500"},
                    new SelectListItem { Text = "5:30 PM", Value = "530"},
                    new SelectListItem { Text = "6:00 PM", Value = "600"},
                    new SelectListItem { Text = "6:30 PM", Value = "630"},
                    new SelectListItem { Text = "7:00 PM", Value = "700"},
                    new SelectListItem { Text = "7:30 PM", Value = "730"},
                }, "Value", "Text");

            ViewBag.Service1 = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "Choose Service 1", Value = "0"},
                    new SelectListItem { Text = "----- PEDICURE -----", Value = "0"},
                    new SelectListItem { Text = "The Royal Spa CBD Pedicure", Value = "The Royal Spa CBD Pedicure"},
                    new SelectListItem { Text = "The Elegant Spa Pedicure", Value = "The Elegant Spa Pedicure"},
                    new SelectListItem { Text = "The Organic Pedicure", Value = "The Organic Pedicure"},
                    new SelectListItem { Text = "The Freshly Spa Pedicure", Value = "The Freshly Spa Pedicure"},
                    new SelectListItem { Text = "The Deluxe Spa Pedicure", Value = "The Deluxe Spa Pedicure"},
                    new SelectListItem { Text = "The Hot Stone Pedicure", Value = "The Hot Stone Pedicure"},
                    new SelectListItem { Text = "The Classic Pedicure", Value = "The Classic Pedicure"},
                    new SelectListItem { Text = "----- MANICURE -----", Value = "0"},
                    new SelectListItem { Text = "The Royal Spa CBD Manicure", Value = "The Royal Spa CBD Manicure"},
                    new SelectListItem { Text = "The Elegant Spa Manicure", Value = "The Elegant Spa Manicure"},
                    new SelectListItem { Text = "The Organic Manicure", Value = "The Organic Manicure"},
                    new SelectListItem { Text = "The Freshly Spa Manicure", Value = "The Freshly Spa Manicure"},
                    new SelectListItem { Text = "The Deluxe Spa Manicure", Value = "The Deluxe Spa Manicure"},
                    new SelectListItem { Text = "The Hot Stone Manicure", Value = "The Hot Stone Manicure"},
                    new SelectListItem { Text = "The Classic Manicure", Value = "The Classic Manicure"},
                    new SelectListItem { Text = "Gel/Shellac Manicure", Value = "Gel/Shellac Manicure"},
                    new SelectListItem { Text = "----- KIDS (12 & under) -----", Value = "0"},
                    new SelectListItem { Text = "Kids Classic Pedicure", Value = "Kids Classic Pedicure"},
                    new SelectListItem { Text = "Kids Deluxe Pedicure", Value = "Kids Deluxe Pedicure"},
                    new SelectListItem { Text = "Kids Manicure", Value = "Kids Manicure"},
                    new SelectListItem { Text = "Polish Change Hand", Value = "Polish Change Hand"},
                    new SelectListItem { Text = "Polish Change Feet", Value = "Polish Change Feet"},
                    new SelectListItem { Text = "Design", Value = "Design"},
                    new SelectListItem { Text = "----- DIPPING GEL -----", Value = "0"},
                    new SelectListItem { Text = "Dipping on Natural Nails", Value = "Dipping on Natural Nails"},
                    new SelectListItem { Text = "Dipping Ombre", Value = "Dipping Ombre"},
                    new SelectListItem { Text = "Dipping & Classic Manicure", Value = "Dipping & Classic Manicure"},
                    new SelectListItem { Text = "Dipping & Deluxe Manicure", Value = "Dipping & Deluxe Manicure"},
                    new SelectListItem { Text = "Dipping & Organic Manicure", Value = "Dipping & Organic Manicure"},
                    new SelectListItem { Text = "Add Tip", Value = "Add Tip"},
                    new SelectListItem { Text = "----- SOLAR/PINK & WHITE -----", Value = "0"},
                    new SelectListItem { Text = "Full Set", Value = "Full Set"},
                    new SelectListItem { Text = "Fill", Value = "Fill"},
                    new SelectListItem { Text = "Fill Pink", Value = "Fill Pink"},
                    new SelectListItem { Text = "Take Off with Service", Value = "Take Off with Service"},
                    new SelectListItem { Text = "----- ACRYLIC -----", Value = "0"},
                    new SelectListItem { Text = "Full Set Color Powder", Value = "Full Set Color Powder"},
                    new SelectListItem { Text = "Full Set Ombre", Value = "Full Set Ombre"},
                    new SelectListItem { Text = "Fill Color Powder (Same Color)", Value = "Fill Color Powder (Same Color)"},
                    new SelectListItem { Text = "Fill Color Powder (Different Color)", Value = "Fill Color Powder (Different Color)"},
                    new SelectListItem { Text = "Regular Full Set", Value = "Regular Full Set"},
                    new SelectListItem { Text = "Regular Full-in", Value = "Regular Full-in"},
                    new SelectListItem { Text = "Add Gel", Value = "Add Gel"},
                    new SelectListItem { Text = "----- EYELASH EXTENSIONS -----", Value = "0"},
                    new SelectListItem { Text = "Lash Extensions New", Value = "Lash Extensions New"},
                    new SelectListItem { Text = "Lash Extensions Fill", Value = "Lash Extensions Fill"},
                    new SelectListItem { Text = "----- WAXING -----", Value = "0"},
                    new SelectListItem { Text = "Eyebrows", Value = "Eyebrows"},
                    new SelectListItem { Text = "Lips", Value = "Lips"},
                    new SelectListItem { Text = "Chin", Value = "Chin"},
                    new SelectListItem { Text = "Sideburn", Value = "Sideburn"},
                    new SelectListItem { Text = "Full Face", Value = "Full Face"},
                    new SelectListItem { Text = "Underarms Wax", Value = "Underarms Wax"},
                    new SelectListItem { Text = "Arms Wax", Value = "Arms Wax"},
                    new SelectListItem { Text = "Full Legs Wax", Value = "Full Legs Wax"},
                    new SelectListItem { Text = "Half Legs Wax", Value = "Half Legs Wax"},
                    new SelectListItem { Text = "Back Wax", Value = "Back Wax"},
                    new SelectListItem { Text = "Bikini Wax", Value = "Bikini Wax"},
                    new SelectListItem { Text = "Brazilian Wax", Value = "Brazilian Wax"},
                    new SelectListItem { Text = "Eyebrow Tint", Value = "Eyebrow Tint"},
                    new SelectListItem { Text = "----- OTHERS -----", Value = "0"},
                    new SelectListItem { Text = "Other Service", Value = "Other"},
                    
                }, "Value", "Text");

            ViewBag.Service2 = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "Choose Service 2", Value = "0"},
                    new SelectListItem { Text = "----- PEDICURE -----", Value = "0"},
                    new SelectListItem { Text = "The Royal Spa CBD Pedicure", Value = "The Royal Spa CBD Pedicure"},
                    new SelectListItem { Text = "The Elegant Spa Pedicure", Value = "The Elegant Spa Pedicure"},
                    new SelectListItem { Text = "The Organic Pedicure", Value = "The Organic Pedicure"},
                    new SelectListItem { Text = "The Freshly Spa Pedicure", Value = "The Freshly Spa Pedicure"},
                    new SelectListItem { Text = "The Deluxe Spa Pedicure", Value = "The Deluxe Spa Pedicure"},
                    new SelectListItem { Text = "The Hot Stone Pedicure", Value = "The Hot Stone Pedicure"},
                    new SelectListItem { Text = "The Classic Pedicure", Value = "The Classic Pedicure"},
                    new SelectListItem { Text = "----- MANICURE -----", Value = "0"},
                    new SelectListItem { Text = "The Royal Spa CBD Manicure", Value = "The Royal Spa CBD Manicure"},
                    new SelectListItem { Text = "The Elegant Spa Manicure", Value = "The Elegant Spa Manicure"},
                    new SelectListItem { Text = "The Organic Manicure", Value = "The Organic Manicure"},
                    new SelectListItem { Text = "The Freshly Spa Manicure", Value = "The Freshly Spa Manicure"},
                    new SelectListItem { Text = "The Deluxe Spa Manicure", Value = "The Deluxe Spa Manicure"},
                    new SelectListItem { Text = "The Hot Stone Manicure", Value = "The Hot Stone Manicure"},
                    new SelectListItem { Text = "The Classic Manicure", Value = "The Classic Manicure"},
                    new SelectListItem { Text = "Gel/Shellac Manicure", Value = "Gel/Shellac Manicure"},
                    new SelectListItem { Text = "----- KIDS (12 & under) -----", Value = "0"},
                    new SelectListItem { Text = "Kids Classic Pedicure", Value = "Kids Classic Pedicure"},
                    new SelectListItem { Text = "Kids Deluxe Pedicure", Value = "Kids Deluxe Pedicure"},
                    new SelectListItem { Text = "Kids Manicure", Value = "Kids Manicure"},
                    new SelectListItem { Text = "Polish Change Hand", Value = "Polish Change Hand"},
                    new SelectListItem { Text = "Polish Change Feet", Value = "Polish Change Feet"},
                    new SelectListItem { Text = "Design", Value = "Design"},
                    new SelectListItem { Text = "----- DIPPING GEL -----", Value = "0"},
                    new SelectListItem { Text = "Dipping on Natural Nails", Value = "Dipping on Natural Nails"},
                    new SelectListItem { Text = "Dipping Ombre", Value = "Dipping Ombre"},
                    new SelectListItem { Text = "Dipping & Classic Manicure", Value = "Dipping & Classic Manicure"},
                    new SelectListItem { Text = "Dipping & Deluxe Manicure", Value = "Dipping & Deluxe Manicure"},
                    new SelectListItem { Text = "Dipping & Organic Manicure", Value = "Dipping & Organic Manicure"},
                    new SelectListItem { Text = "Add Tip", Value = "Add Tip"},
                    new SelectListItem { Text = "----- SOLAR/PINK & WHITE -----", Value = "0"},
                    new SelectListItem { Text = "Full Set", Value = "Full Set"},
                    new SelectListItem { Text = "Fill", Value = "Fill"},
                    new SelectListItem { Text = "Fill Pink", Value = "Fill Pink"},
                    new SelectListItem { Text = "Take Off with Service", Value = "Take Off with Service"},
                    new SelectListItem { Text = "----- ACRYLIC -----", Value = "0"},
                    new SelectListItem { Text = "Full Set Color Powder", Value = "Full Set Color Powder"},
                    new SelectListItem { Text = "Full Set Ombre", Value = "Full Set Ombre"},
                    new SelectListItem { Text = "Fill Color Powder (Same Color)", Value = "Fill Color Powder (Same Color)"},
                    new SelectListItem { Text = "Fill Color Powder (Different Color)", Value = "Fill Color Powder (Different Color)"},
                    new SelectListItem { Text = "Regular Full Set", Value = "Regular Full Set"},
                    new SelectListItem { Text = "Regular Full-in", Value = "Regular Full-in"},
                    new SelectListItem { Text = "Add Gel", Value = "Add Gel"},
                    new SelectListItem { Text = "----- EYELASH EXTENSIONS -----", Value = "0"},
                    new SelectListItem { Text = "Lash Extensions New", Value = "Lash Extensions New"},
                    new SelectListItem { Text = "Lash Extensions Fill", Value = "Lash Extensions Fill"},
                    new SelectListItem { Text = "----- WAXING -----", Value = "0"},
                    new SelectListItem { Text = "Eyebrows", Value = "Eyebrows"},
                    new SelectListItem { Text = "Lips", Value = "Lips"},
                    new SelectListItem { Text = "Chin", Value = "Chin"},
                    new SelectListItem { Text = "Sideburn", Value = "Sideburn"},
                    new SelectListItem { Text = "Full Face", Value = "Full Face"},
                    new SelectListItem { Text = "Underarms Wax", Value = "Underarms Wax"},
                    new SelectListItem { Text = "Arms Wax", Value = "Arms Wax"},
                    new SelectListItem { Text = "Full Legs Wax", Value = "Full Legs Wax"},
                    new SelectListItem { Text = "Half Legs Wax", Value = "Half Legs Wax"},
                    new SelectListItem { Text = "Back Wax", Value = "Back Wax"},
                    new SelectListItem { Text = "Bikini Wax", Value = "Bikini Wax"},
                    new SelectListItem { Text = "Brazilian Wax", Value = "Brazilian Wax"},
                    new SelectListItem { Text = "Eyebrow Tint", Value = "Eyebrow Tint"},
                    new SelectListItem { Text = "----- OTHERS -----", Value = "0"},
                    new SelectListItem { Text = "Other Service", Value = "Other"},

                }, "Value", "Text");

            ViewBag.Service3 = new SelectList(
                new List<SelectListItem>
                {
                    new SelectListItem { Text = "Choose Service 3", Value = "0"},
                    new SelectListItem { Text = "----- PEDICURE -----", Value = "0"},
                    new SelectListItem { Text = "The Royal Spa CBD Pedicure", Value = "The Royal Spa CBD Pedicure"},
                    new SelectListItem { Text = "The Elegant Spa Pedicure", Value = "The Elegant Spa Pedicure"},
                    new SelectListItem { Text = "The Organic Pedicure", Value = "The Organic Pedicure"},
                    new SelectListItem { Text = "The Freshly Spa Pedicure", Value = "The Freshly Spa Pedicure"},
                    new SelectListItem { Text = "The Deluxe Spa Pedicure", Value = "The Deluxe Spa Pedicure"},
                    new SelectListItem { Text = "The Hot Stone Pedicure", Value = "The Hot Stone Pedicure"},
                    new SelectListItem { Text = "The Classic Pedicure", Value = "The Classic Pedicure"},
                    new SelectListItem { Text = "----- MANICURE -----", Value = "0"},
                    new SelectListItem { Text = "The Royal Spa CBD Manicure", Value = "The Royal Spa CBD Manicure"},
                    new SelectListItem { Text = "The Elegant Spa Manicure", Value = "The Elegant Spa Manicure"},
                    new SelectListItem { Text = "The Organic Manicure", Value = "The Organic Manicure"},
                    new SelectListItem { Text = "The Freshly Spa Manicure", Value = "The Freshly Spa Manicure"},
                    new SelectListItem { Text = "The Deluxe Spa Manicure", Value = "The Deluxe Spa Manicure"},
                    new SelectListItem { Text = "The Hot Stone Manicure", Value = "The Hot Stone Manicure"},
                    new SelectListItem { Text = "The Classic Manicure", Value = "The Classic Manicure"},
                    new SelectListItem { Text = "Gel/Shellac Manicure", Value = "Gel/Shellac Manicure"},
                    new SelectListItem { Text = "----- KIDS (12 & under) -----", Value = "0"},
                    new SelectListItem { Text = "Kids Classic Pedicure", Value = "Kids Classic Pedicure"},
                    new SelectListItem { Text = "Kids Deluxe Pedicure", Value = "Kids Deluxe Pedicure"},
                    new SelectListItem { Text = "Kids Manicure", Value = "Kids Manicure"},
                    new SelectListItem { Text = "Polish Change Hand", Value = "Polish Change Hand"},
                    new SelectListItem { Text = "Polish Change Feet", Value = "Polish Change Feet"},
                    new SelectListItem { Text = "Design", Value = "Design"},
                    new SelectListItem { Text = "----- DIPPING GEL -----", Value = "0"},
                    new SelectListItem { Text = "Dipping on Natural Nails", Value = "Dipping on Natural Nails"},
                    new SelectListItem { Text = "Dipping Ombre", Value = "Dipping Ombre"},
                    new SelectListItem { Text = "Dipping & Classic Manicure", Value = "Dipping & Classic Manicure"},
                    new SelectListItem { Text = "Dipping & Deluxe Manicure", Value = "Dipping & Deluxe Manicure"},
                    new SelectListItem { Text = "Dipping & Organic Manicure", Value = "Dipping & Organic Manicure"},
                    new SelectListItem { Text = "Add Tip", Value = "Add Tip"},
                    new SelectListItem { Text = "----- SOLAR/PINK & WHITE -----", Value = "0"},
                    new SelectListItem { Text = "Full Set", Value = "Full Set"},
                    new SelectListItem { Text = "Fill", Value = "Fill"},
                    new SelectListItem { Text = "Fill Pink", Value = "Fill Pink"},
                    new SelectListItem { Text = "Take Off with Service", Value = "Take Off with Service"},
                    new SelectListItem { Text = "----- ACRYLIC -----", Value = "0"},
                    new SelectListItem { Text = "Full Set Color Powder", Value = "Full Set Color Powder"},
                    new SelectListItem { Text = "Full Set Ombre", Value = "Full Set Ombre"},
                    new SelectListItem { Text = "Fill Color Powder (Same Color)", Value = "Fill Color Powder (Same Color)"},
                    new SelectListItem { Text = "Fill Color Powder (Different Color)", Value = "Fill Color Powder (Different Color)"},
                    new SelectListItem { Text = "Regular Full Set", Value = "Regular Full Set"},
                    new SelectListItem { Text = "Regular Full-in", Value = "Regular Full-in"},
                    new SelectListItem { Text = "Add Gel", Value = "Add Gel"},
                    new SelectListItem { Text = "----- EYELASH EXTENSIONS -----", Value = "0"},
                    new SelectListItem { Text = "Lash Extensions New", Value = "Lash Extensions New"},
                    new SelectListItem { Text = "Lash Extensions Fill", Value = "Lash Extensions Fill"},
                    new SelectListItem { Text = "----- WAXING -----", Value = "0"},
                    new SelectListItem { Text = "Eyebrows", Value = "Eyebrows"},
                    new SelectListItem { Text = "Lips", Value = "Lips"},
                    new SelectListItem { Text = "Chin", Value = "Chin"},
                    new SelectListItem { Text = "Sideburn", Value = "Sideburn"},
                    new SelectListItem { Text = "Full Face", Value = "Full Face"},
                    new SelectListItem { Text = "Underarms Wax", Value = "Underarms Wax"},
                    new SelectListItem { Text = "Arms Wax", Value = "Arms Wax"},
                    new SelectListItem { Text = "Full Legs Wax", Value = "Full Legs Wax"},
                    new SelectListItem { Text = "Half Legs Wax", Value = "Half Legs Wax"},
                    new SelectListItem { Text = "Back Wax", Value = "Back Wax"},
                    new SelectListItem { Text = "Bikini Wax", Value = "Bikini Wax"},
                    new SelectListItem { Text = "Brazilian Wax", Value = "Brazilian Wax"},
                    new SelectListItem { Text = "Eyebrow Tint", Value = "Eyebrow Tint"},
                    new SelectListItem { Text = "----- OTHERS -----", Value = "0"},
                    new SelectListItem { Text = "Other Service", Value = "Other"},

                }, "Value", "Text");

            return View();
        }

        public ActionResult Direction()
        {
            return View();
        }
    }
}
