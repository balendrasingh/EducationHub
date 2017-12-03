using BackendBO.BusinessObjects;
using BackendBO.Response;
using BckendBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.AppCode
{
    public class PersonHelper
    {
        public PersonResponse PersonAdd(EH_Person person_)
        {
            PersonResponse personResponse = new PersonResponse();
            PersonManager personManager = new PersonManager();
            personResponse = personManager.PersonAdd(person_);
            return personResponse;
        }

        public PersonResponse PersonEdit(EH_Person person_)
        {
            PersonResponse personResponse = new PersonResponse();
            PersonManager personManager = new PersonManager();
            personResponse = personManager.PersonEdit(person_);
            return personResponse;
        }

        public PersonResponse GetPersonList()
        {
            PersonResponse personResponse = new PersonResponse();
            PersonManager personManager = new PersonManager();
            personResponse = personManager.GetPersonList();
            return personResponse;
        }
        public PersonResponse GetPersonDetails(decimal personId_)
        {
            PersonResponse personResponse = new PersonResponse();
            PersonManager personManager = new PersonManager();
            personResponse = personManager.GetPersonDetails(personId_);
            return personResponse;
        }
    }
}