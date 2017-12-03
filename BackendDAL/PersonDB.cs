using BackendBO.BusinessObjects;
using BackendBO.Response;
using BackendDAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BackendDAL
{
    public class PersonDB
    {
        public PersonResponse PersonAdd(EH_Person person_)
        {
            decimal personId;
            PersonResponse personResponse = new PersonResponse();
            using (EHContext context = new EHContext())
            {
                using (DbContextTransaction contextTransaction = context.Database.BeginTransaction())
                {
                    EH_Person person = new EH_Person()
                    {
                        PersonName = person_.PersonName,
                        PersonMailID = person_.PersonMailID,
                        UserName = person_.UserName,
                        Password = person_.Password,
                        Enabled = true,
                        Deleted = false
                    };
                    context.EH_Person.Add(person);
                    context.SaveChanges();
                    personId = person.PersonId;

                    EH_PersonRoleMapping personRoleMapping = new EH_PersonRoleMapping()
                    {
                        PersonId = personId,
                        RoleId = person_.RoleId,
                        Enabled = true,
                        Deleted = false
                    };

                    context.EH_PersonRoleMapping.Add(personRoleMapping);
                    context.SaveChanges();
                    contextTransaction.Commit();
                }
            }
            return personResponse;
        }

        public PersonResponse PersonEdit(EH_Person person_)
        {
            PersonResponse personResponse = new PersonResponse();
            using (EHContext context = new EHContext())
            {
                using (DbContextTransaction contextTransaction = context.Database.BeginTransaction())
                {
                    EH_Person person = context.EH_Person.Where(p => p.PersonId == person_.PersonId && p.Deleted == false).FirstOrDefault();
                    person.PersonName = person_.PersonName;
                    person.PersonMailID = person_.PersonMailID;
                    person.UserName = person_.UserName;
                    person.Password = person_.Password;
                    person.Enabled = person_.Enabled;
                    context.SaveChanges();

                    EH_PersonRoleMapping personRoleMapping = context.EH_PersonRoleMapping.Where(prm => prm.PersonId == person_.PersonId).FirstOrDefault();
                    personRoleMapping.RoleId = person_.RoleId;
                    personRoleMapping.Enabled = person_.Enabled;
                    context.SaveChanges();
                    contextTransaction.Commit();
                }
            }
            return personResponse;
        }

        public PersonResponse GetPersonDetails(decimal personId_)
        {
            PersonResponse personResponse = new PersonResponse();
            EH_Person person = new EH_Person();
            using (EHContext context = new EHContext())
            {
                var personDetails = (from p in context.EH_Person
                                     join prm in context.EH_PersonRoleMapping on p.PersonId equals prm.PersonId
                                     where p.PersonId == personId_
                                     select new
                                     {
                                         PersonId = p.PersonId,
                                         PersonName = p.PersonName,
                                         PersonMailID = p.PersonMailID,
                                         UserName = p.UserName,
                                         password = p.Password,
                                         RoleId = prm.RoleId,
                                         Enabled=p.Enabled
                                     }).FirstOrDefault();

                person.PersonId = personDetails.PersonId;
                person.PersonName = personDetails.PersonName;
                person.PersonMailID = personDetails.PersonMailID;
                person.UserName = personDetails.UserName;
                person.Password = personDetails.password;
                person.Enabled = Convert.ToBoolean(personDetails.Enabled);
                person.RoleId = personDetails.RoleId ?? 0;
                personResponse = new PersonResponse(person, BaseResponse.ResponseStatus.Success);
            }
            return personResponse;
        }

        public PersonResponse GetPersonList()
        {
            PersonResponse personResponse = new PersonResponse();
            EH_Person person;
            List<EH_Person> personList = new List<EH_Person>();
            using (EHContext context = new EHContext())
            {
                var persons = (from p in context.EH_Person
                                     join prm in context.EH_PersonRoleMapping on p.PersonId equals prm.PersonId
                                     join r in context.EH_Role on prm.RoleId equals r.RoleId
                                     where p.Deleted == false
                                     select new
                                     {
                                         PersonId = p.PersonId,
                                         PersonName = p.PersonName,
                                         PersonMailID = p.PersonMailID,
                                         UserName = p.UserName,
                                         password = p.Password,
                                         RoleName = r.RoleName,
                                         Enabled = p.Enabled
                                     }).ToList();

                foreach (var item in persons)
                {
                    person = new EH_Person();
                    person.PersonId = item.PersonId;
                    person.PersonName = item.PersonName;
                    person.PersonMailID = item.PersonMailID;
                    person.UserName = item.UserName;
                    person.Enabled = Convert.ToBoolean(item.Enabled);
                    person.RoleName = item.RoleName;
                    personList.Add(person);
                }

                personResponse = new PersonResponse(personList, BaseResponse.ResponseStatus.Success);
            }
            return personResponse;
        }
    }
}