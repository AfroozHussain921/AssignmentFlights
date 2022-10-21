using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_Flightss;

namespace Assignment_Flightss.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Cities()
        {
            CitiesService citiesService = new CitiesService();
            IList<Citiesdb>  city = citiesService.GetCitiesdbs();

            return View(city);
        }
    }
}