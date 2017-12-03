﻿using BackendBO.Response;
using BackendDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BckendBAL
{
    public class MasterManager
    {
        public MasterResponse GetAllRoles()
        {
            MasterResponse masterResponse = new MasterResponse();
            try
            {
                //WebRequestLogManager objWebRequestLogManager = new WebRequestLogManager();
                //decimal requestId = objWebRequestLogManager.AddRequest(string.Format("Project {0}, Page {1}, Method {2}, currentCulture {3}, clientID {4}, statusids {5}, partnertypecodes {6}", "ELSBackendBLL", "masterManager.cs", "GetAllPartners", culture, clientId, statusids, partnertypecodes), 0, CommonFunctions.RequestSource.WEB.ToString());
                MasterDB masterDB = new MasterDB();
                masterResponse = masterDB.GetAllRoles();
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
                masterResponse = new MasterResponse(BaseResponse.ResponseStatus.Error);
            }

            return masterResponse;

        }
    }
}