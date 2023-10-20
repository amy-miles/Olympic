using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Olympics.Models;
using System.Diagnostics;

namespace Olympics.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController (CountryContext ctx) => context = ctx;

        public ViewResult Index(CountriesViewModel model)
        {
            model.Games = context.Games.ToList();
            model.Sports = context.Sports.ToList();           

            //get countries and filter by Game and Division
            IQueryable<Country> query = context.Countries.OrderBy(c => c.Name);
            if (model.ActiveGame != "all") 
                query = query.Where(c => c.Game.GameID.ToLower() == model.ActiveGame.ToLower());
            if (model.ActiveSport != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == model.ActiveSport.ToLower());

            //pass list of countries to view as model
            model.Countries = query.ToList();
            return View(model);
        }

      

        public IActionResult Details(string id)
        {
            var country = context.Countries
                .Include(c => c.Game)
                .Include(c => c.Sport)
                .FirstOrDefault(c => c.CountryID == id) ?? new Country();
            return View(country);
        }

    }
}