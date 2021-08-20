using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebAppMvc.Attribute;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppMvc.Models
{
    public class UserModel
    {

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Confirm Password should match with password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Enter valid contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="",Text="Select"},
            new SelectListItem {Value="1",Text="India"},
            new SelectListItem {Value="2",Text="Englaind"}
        };

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        public List<SelectListItem> Cities { get; } = new List<SelectListItem>
        {

        };


        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }
        public string[] Genders = new[] { "Male", "Female" };


        [ValidateCheckBox(ErrorMessage = "Please accept terms")]
        [Display(Name = "Accept Terms")]
        public bool AcceptTerms { get; set; }


    }

    public class City
    {
        public string CityId { get; set; }
        public string CityName { get; set; }

        public string CountryId { get; set; }
    }
}
