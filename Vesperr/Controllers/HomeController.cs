using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;
using Vesperr.Models.ModelBinding;

namespace Vesperr.Controllers
{
    public class HomeController : Controller
    {
        private readonly Mycontext db;

        public HomeController(Mycontext mycontext)
        {
            db = mycontext;
        }

        public IActionResult Index()
        {
            AllModels models = new AllModels()
            {
                headers = db.Heroheaders.First(),
                abouts = db.Abouts.First(),
                aboutcounts = db.AboutCounts.ToList(),
                clientsections = db.ClientSections.ToList(),
                contacts = db.Contacts.First(),
                features = db.Features.ToList(),
                moreservicesections=db.MoreServiceSections.ToList(),
                portfolios = db.Portfolios.ToList(),
                pricings = db.Pricings.ToList(),
                questions = db.Questions.ToList(),
                servicesections = db.ServiceSections.ToList(),
                teams = db.Teams.ToList(),
                testimionals = db.Testimionals.ToList()
            };
            return View(models);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
