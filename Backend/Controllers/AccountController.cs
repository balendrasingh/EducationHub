using Backend.AppCode;
using Backend.Models;
using BackendBO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Backend.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(PersonModel personModel_)
        {
            PersonResponse personResponse = new PersonResponse();
            AccountHelper accountHelper = new AccountHelper();
            personResponse = accountHelper.AuthenticateUser(personModel_.UserName, personModel_.Password);
            if(personResponse.Person != null)
            {
                FormsAuthentication.SetAuthCookie(personModel_.UserName, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }
        }
    }
}