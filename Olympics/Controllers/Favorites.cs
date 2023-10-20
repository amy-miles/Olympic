using Microsoft.AspNetCore.Mvc;
using Olympics.Models;

namespace Olympics.Controllers
{
    public class Favorites : Controller
    {
       [HttpPost]
       public RedirectToActionResult Add(Country country)
        {
            //code to store favorte country in session goes here in chapter 9
            //wont actually store any data unitl updated in ch 9
            TempData["message"] = $"{country.Name} added to your favorites";

            return RedirectToAction("Index", "Home");
        }
    }
}
