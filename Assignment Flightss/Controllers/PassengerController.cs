using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_Flightss;
using Assignment_Flightss.Models;


namespace Assignment_Flightss.Controllers
{
    public class PassengerController : Controller
    {
        PassengerService passengerService = new PassengerService();
        // GET: Passenger

        public ActionResult Passengers()
        {

            Airport model = new Airport();  

            model.Passanger = passengerService.GetPassangerList();

            return View(model);
        }
        [HttpGet]
        public ActionResult PassengerEditor(int passengerId)
        {
            AirportModel model = passengerService.PreparePassengerEdit(passengerId);
            return View(model);
        }
        [HttpPost]
        public ActionResult PassengerEditor(AirportModel model)
        {
            passengerService.SavePassenger(model);

            return RedirectToAction("Passanger");

        }
        [HttpPost]
        public ActionResult DeletePassenger(int passengerId)
        {
            var Isdeleted = passengerService.DeletePassenger(passengerId);

            return Json(Isdeleted, JsonRequestBehavior.AllowGet);
        }

    }
}