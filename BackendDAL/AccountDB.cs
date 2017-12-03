using BackendBO.BusinessObjects;
using BackendBO.Response;
using BackendDAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendDAL
{
    public class AccountDB
    {
        public PersonResponse AuthenticateUser(string userName_, string password_)
        {
            PersonResponse personResponse = new PersonResponse();
            EH_Person person = new EH_Person();
            using (EHContext context = new EHContext())
            {
                var personDetails = (from p in context.EH_Person
                                     join prm in context.EH_PersonRoleMapping on p.PersonId equals prm.PersonId
                                     where p.UserName == userName_ && p.Password==password_
                                     select new
                                     {
                                         PersonName = p.PersonName,
                                         PersonMailID = p.PersonMailID,
                                         UserName = p.UserName,
                                         password = p.Password,
                                         RoleId = prm.RoleId,
                                         Enabled = p.Enabled
                                     }).FirstOrDefault();

                if (personDetails != null)
                {
                    person.PersonName = personDetails.PersonName;
                    person.PersonMailID = personDetails.PersonMailID;
                    person.UserName = personDetails.UserName;
                    person.Password = personDetails.password;
                    person.Enabled = Convert.ToBoolean(personDetails.Enabled);
                    person.RoleId = personDetails.RoleId ?? 0;
                }
                else
                {
                    person = null;
                }

                personResponse = new PersonResponse(person, BaseResponse.ResponseStatus.Success);
            }
            return personResponse;
        }
    }
}