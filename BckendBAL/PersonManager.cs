using BackendBO.BusinessObjects;
using BackendBO.Response;
using BackendDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BckendBAL
{
    public class PersonManager
    {
        public PersonResponse PersonAdd(EH_Person person_)
        {
            PersonResponse personResponse = new PersonResponse();
            try
            {
                //WebRequestLogManager objWebRequestLogManager = new WebRequestLogManager();
                //decimal requestId = objWebRequestLogManager.AddRequest(string.Format("Project {0}, Page {1}, Method {2}, currentCulture {3}, clientID {4}, statusids {5}, partnertypecodes {6}", "ELSBackendBLL", "masterManager.cs", "GetAllPartners", culture, clientId, statusids, partnertypecodes), 0, CommonFunctions.RequestSource.WEB.ToString());
                PersonDB personDB = new PersonDB();
                personResponse = personDB.PersonAdd(person_);
                //objWebRequestLogManager.AddResponse(masterResponse.Status.ToString(), requestId, 0);
            }
            //catch (CustomException ex)
            //{
            //    masterResponse = new MasterResponse(ex.ResponseStatus);
            //}
            catch (Exception ex)
            {

                //var Error = "Exception : " + ex.Message + ", Inner Exception : " + (ex.InnerException == null ? "" : ex.InnerException.Message);
                //ExceptionLogDB.LogException("ELSBAL", "MasterManager.cs", "GetAllRoles", CommonFunctions.RequestSource.WEB.ToString(), Error);
                personResponse = new PersonResponse(BaseResponse.ResponseStatus.Error);
            }

            return personResponse;

        }

        public PersonResponse PersonEdit(EH_Person person_)
        {
            PersonResponse personResponse = new PersonResponse();
            try
            {
                //WebRequestLogManager objWebRequestLogManager = new WebRequestLogManager();
                //decimal requestId = objWebRequestLogManager.AddRequest(string.Format("Project {0}, Page {1}, Method {2}, currentCulture {3}, clientID {4}, statusids {5}, partnertypecodes {6}", "ELSBackendBLL", "masterManager.cs", "GetAllPartners", culture, clientId, statusids, partnertypecodes), 0, CommonFunctions.RequestSource.WEB.ToString());
                PersonDB personDB = new PersonDB();
                personResponse = personDB.PersonEdit(person_);
                //objWebRequestLogManager.AddResponse(masterResponse.Status.ToString(), requestId, 0);
            }
            //catch (CustomException ex)
            //{
            //    masterResponse = new MasterResponse(ex.ResponseStatus);
            //}
            catch (Exception ex)
            {

                //var Error = "Exception : " + ex.Message + ", Inner Exception : " + (ex.InnerException == null ? "" : ex.InnerException.Message);
                //ExceptionLogDB.LogException("ELSBAL", "MasterManager.cs", "GetAllRoles", CommonFunctions.RequestSource.WEB.ToString(), Error);
                personResponse = new PersonResponse(BaseResponse.ResponseStatus.Error);
            }

            return personResponse;

        }

      
        public PersonResponse GetPersonDetails(decimal personId_)
        {
            PersonResponse personResponse = new PersonResponse();
            try
            {
                //WebRequestLogManager objWebRequestLogManager = new WebRequestLogManager();
                //decimal requestId = objWebRequestLogManager.AddRequest(string.Format("Project {0}, Page {1}, Method {2}, currentCulture {3}, clientID {4}, statusids {5}, partnertypecodes {6}", "ELSBackendBLL", "masterManager.cs", "GetAllPartners", culture, clientId, statusids, partnertypecodes), 0, CommonFunctions.RequestSource.WEB.ToString());
                PersonDB personDB = new PersonDB();
                personResponse = personDB.GetPersonDetails(personId_);
                //objWebRequestLogManager.AddResponse(masterResponse.Status.ToString(), requestId, 0);
            }
            //catch (CustomException ex)
            //{
            //    masterResponse = new MasterResponse(ex.ResponseStatus);
            //}
            catch (Exception ex)
            {

                //var Error = "Exception : " + ex.Message + ", Inner Exception : " + (ex.InnerException == null ? "" : ex.InnerException.Message);
                //ExceptionLogDB.LogException("ELSBAL", "MasterManager.cs", "GetAllRoles", CommonFunctions.RequestSource.WEB.ToString(), Error);
                personResponse = new PersonResponse(BaseResponse.ResponseStatus.Error);
            }

            return personResponse;

        }

        public PersonResponse GetPersonList()
        {
            PersonResponse personResponse = new PersonResponse();
            try
            {
                //WebRequestLogManager objWebRequestLogManager = new WebRequestLogManager();
                //decimal requestId = objWebRequestLogManager.AddRequest(string.Format("Project {0}, Page {1}, Method {2}, currentCulture {3}, clientID {4}, statusids {5}, partnertypecodes {6}", "ELSBackendBLL", "masterManager.cs", "GetAllPartners", culture, clientId, statusids, partnertypecodes), 0, CommonFunctions.RequestSource.WEB.ToString());
                PersonDB personDB = new PersonDB();
                personResponse = personDB.GetPersonList();
                //objWebRequestLogManager.AddResponse(masterResponse.Status.ToString(), requestId, 0);
            }
            //catch (CustomException ex)
            //{
            //    masterResponse = new MasterResponse(ex.ResponseStatus);
            //}
            catch (Exception ex)
            {

                //var Error = "Exception : " + ex.Message + ", Inner Exception : " + (ex.InnerException == null ? "" : ex.InnerException.Message);
                //ExceptionLogDB.LogException("ELSBAL", "MasterManager.cs", "GetAllRoles", CommonFunctions.RequestSource.WEB.ToString(), Error);
                personResponse = new PersonResponse(BaseResponse.ResponseStatus.Error);
            }

            return personResponse;

        }
    }
}
