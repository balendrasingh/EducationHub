using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackendBO.BusinessObjects;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class PersonModel
    {
        public decimal PersonId { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Please enter valid Email")]
        public string PersonMailID { get; set; }

        [Required(ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public bool Enabled { get; set; }

        public int Deleted { get; set; }

        public decimal RoleId { get; set; }
        public EH_Role Role { get; set; }

        [Required(ErrorMessage = "Please Select Role")]
        public List<EH_Role> Roles { get; set; }
        public IEnumerable<SelectListItem> RoleListItems { get; set; }

        public List<EH_Person> Persons { get; set; }
    }
}