using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Assignment_Flightss;


namespace Assignment_Flightss.Models
{
    public class AirportModel
    {
        public int passengerID { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "string lenght should not exceed 10")]
        public string Nameofpassenger { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> MobileNo { get; set; }
        public string Address { get; set; }
        public Nullable<int> CitiesID { get; set; }
        public Nullable<int> FlightID { get; set; }

        public IList<SelectListItem> FlightList { get; set; }

        public IList<SelectListItem> CitiesList { get; set; }
    }
}