using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvc.Models;

namespace WebAppMvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            return View();
        }

        public IActionResult SignUp()
        {
            UserModel user = new UserModel();
            return View(user);
        }

        [HttpPost]
        public IActionResult SignUp(UserModel user)
        {
            if (ModelState.IsValid)
            {
                return View("UserDetails", user);
            }

            return View(user);
        }

        public JsonResult GetCities(string countryId)
        {
            List<SelectListItem> cities = new List<SelectListItem>();
            List<City> cityList = new List<City>()
            {
                new City{CityId ="1", CityName="Delhi", CountryId="1"},
                new City{CityId ="2", CityName="Mumbai", CountryId="1"},
                new City{CityId ="3", CityName="Lords", CountryId="2"},
                new City{CityId ="4", CityName="Londan", CountryId="2"}
            };
            cities.Add(new SelectListItem { Value = "", Text = "Select" });

            if (string.IsNullOrEmpty(countryId))
                return Json(cities);
            cityList.ForEach(x =>
           {
               if (x.CountryId == countryId)
               {
                   cities.Add(new SelectListItem { Value = x.CityId, Text = x.CityName });
               }
           });

            return Json(cities);
        }
    }




}
