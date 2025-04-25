using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
           VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();

            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "USA", CityName = "New York", VisitPlaceName = "Statue of Liberty" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Turkey", CityName = "Istanbul", VisitPlaceName = "Hagia Sophia" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Italy", CityName = "Rome", VisitPlaceName = "Colosseum" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "France", CityName = "Paris", VisitPlaceName = "Eiffel Tower" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Japan", CityName = "Tokyo", VisitPlaceName = "Tokyo Tower" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Germany", CityName = "Berlin", VisitPlaceName = "Brandenburg Gate" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Spain", CityName = "Barcelona", VisitPlaceName = "Sagrada Familia" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Brazil", CityName = "Rio de Janeiro", VisitPlaceName = "Christ the Redeemer" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Egypt", CityName = "Cairo", VisitPlaceName = "Pyramids of Giza" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "India", CityName = "Agra", VisitPlaceName = "Taj Mahal" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Australia", CityName = "Sydney", VisitPlaceName = "Sydney Opera House" });
            visitRouteMover.AddVisitRoute(new VisitorRoute { CountryName = "Russia", CityName = "Moscow", VisitPlaceName = "Red Square" });

            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName + " " + iterator.CurrentItem.CityName + " " + iterator.CurrentItem.VisitPlaceName);
                
        }
            ViewBag.v = strings;
            return View();
        }
    }
}
