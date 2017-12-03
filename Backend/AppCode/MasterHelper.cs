using BackendBO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BckendBAL;

namespace Backend.AppCode
{
    public class MasterHelper
    {
        public MasterResponse GetAllRoles()
        {
            MasterResponse masterResponse = new MasterResponse();
            MasterManager masterManager = new MasterManager();
            masterResponse = masterManager.GetAllRoles();
            return masterResponse;
        }
    }
}