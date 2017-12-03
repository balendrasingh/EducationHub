using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Backend.Models;
using Backend.AppCode;
using BackendBO.BusinessObjects;
using BackendBO.Response;

namespace Backend.Controllers
{
    [Authorize]
    public class PersonController : Controller
    {
        // GET: Person
        // GET: Base
        [HttpGet]
        public ActionResult PersonList()
        {
            PersonModel personModel = new PersonModel();
            PersonHelper personHelper = new PersonHelper();
            PersonResponse personResponse = new PersonResponse();
            personResponse = personHelper.GetPersonList();
            personModel.Persons = personResponse.Persons;
            return View(personModel);
        }

       

        [HttpGet]
        public ActionResult PersonAdd()
        {
            PersonModel personModel = new PersonModel();
            MasterHelper masterHelper = new MasterHelper();
            MasterResponse masterResponse = new MasterResponse();
            masterResponse = masterHelper.GetAllRoles();
            personModel.Roles = masterResponse.Roles;

            List<SelectListItem> roleListItems = new List<SelectListItem>();
            roleListItems.Add(new SelectListItem { Text = "-Select Sub Category-", Value = string.Empty });
            if (personModel.Roles != null)
            {
                foreach (EH_Role role in personModel.Roles)
                {
                    SelectListItem selectListItem = new SelectListItem { Text = role.RoleName, Value = Convert.ToString(role.RoleId)};
                    roleListItems.Add(selectListItem);
                }
            }
            personModel.RoleListItems = roleListItems;
            return View(personModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PersonAdd(PersonModel personModel_)
        {
          
                PersonResponse personResponse = new PersonResponse();
                PersonHelper personHelper = new PersonHelper();
                EH_Person person = new EH_Person();
                person.PersonName = personModel_.PersonName;
                person.PersonMailID = personModel_.PersonMailID;
                person.UserName = personModel_.UserName;
                person.Password = personModel_.Password;
                person.RoleId = personModel_.RoleId;
                personResponse = personHelper.PersonAdd(person);

            return RedirectToAction("PersonAdd");
        }

        [HttpGet]
        public ActionResult PersonEdit(string id)
        {
            PersonModel personModel = new PersonModel();
            PersonHelper personHelper = new PersonHelper();
            MasterHelper masterHelper = new MasterHelper();
            PersonResponse personResponse = new PersonResponse();
            MasterResponse masterResponse = new MasterResponse();
            masterResponse = masterHelper.GetAllRoles();

            personModel.Roles = masterResponse.Roles;
            List<SelectListItem> roleListItems = new List<SelectListItem>();
            roleListItems.Add(new SelectListItem { Text = "-Select Role-", Value = string.Empty });
            if (personModel.Roles != null)
            {
                foreach (EH_Role role in personModel.Roles)
                {
                    SelectListItem selectListItem = new SelectListItem { Text = role.RoleName, Value = Convert.ToString(role.RoleId) };
                    roleListItems.Add(selectListItem);
                }
            }
            personModel.RoleListItems = roleListItems;

            personResponse = personHelper.GetPersonDetails(Convert.ToDecimal(id));

            if (personResponse.Person != null)
            {
                personModel.PersonId = personResponse.Person.PersonId;
                personModel.PersonName = personResponse.Person.PersonName;
                personModel.PersonMailID = personResponse.Person.PersonMailID;
                personModel.UserName = personResponse.Person.UserName;
                personModel.Password = personResponse.Person.Password;
                personModel.RoleId = personResponse.Person.RoleId;
                personModel.Enabled = personResponse.Person.Enabled ?? true;
            }
            return View(personModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PersonEdit(PersonModel personModel_)
        {
            PersonResponse personResponse = new PersonResponse();
            PersonHelper personHelper = new PersonHelper();
            EH_Person person = new EH_Person();
            person.PersonId = personModel_.PersonId;
            person.PersonName = personModel_.PersonName;
            person.PersonMailID = personModel_.PersonMailID;
            person.UserName = personModel_.UserName;
            person.Password = personModel_.Password;
            person.RoleId = personModel_.RoleId;
            person.Enabled = personModel_.Enabled ;
            personResponse = personHelper.PersonEdit(person);
            return RedirectToAction("PersonList");
        }

        [HttpGet]
        public ActionResult PersonDetails()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonDetails(string check)
        {
            return View();
        }
       
    }
}