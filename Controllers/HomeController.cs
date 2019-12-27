using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using locationfinder.Models;

namespace locationfinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LocationLists model = new LocationLists();
            var locations = new List<Locations>()
            {
                new Locations(1, "IBM DLF1","IBM DLF1, Kolkata", 22.581431, 88.450462),
                new Locations(2, "IBM BCS","IBM BCS, Kolkata", 22.5718, 88.4346),
                new Locations(3, "IBM OZONE 3","IBM OZONE 3, Pune", 18.4908, 73.9524),
                new Locations(4, "IBM Hinjawadi","IBM Hinjawadi, Pune", 18.6057, 73.7159),
                new Locations(5, "IBM Bangalore :: Manyata Embassy Business Park","IBM Bangalore :: Manyata Embassy Business Park, Bangalore", 12.9514, 77.6433),
                new Locations(5, "IBM Chennai","IBM Chennai, Chennai", 13.023099, 80.176303)
            };
            model.LocationList = locations;
            return View(model);
        }
    }
}
