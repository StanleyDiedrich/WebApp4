using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp4.Data.Interfaces;
using WebApp4.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp4.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRep;
        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var homeCars = new HomeViewModel
            {
                //favCars = _carRep.getFavCars
            };
            return View();
        }
    }
}

