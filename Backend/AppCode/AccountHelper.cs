using BackendBO.Response;
using BackendBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Backend.AppCode
{
    public class AccountHelper
    {
        public PersonResponse AuthenticateUser(string userName_, string password_)
        {
            PersonResponse personResponse = new PersonResponse();
            AccountManager personManager = new AccountManager();
            personResponse = personManager.AuthenticateUser(userName_, password_);
            return personResponse;
        }
    }
}