using BackendBO.Response;
using BackendBO.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackendDAL.Data;
namespace BackendDAL
{
    public class MasterDB
    {

        public MasterResponse GetAllRoles()
        {
            MasterResponse masterResponse = null;
            List<EH_Role> roles = new List<EH_Role>();
            using (EHContext context = new EHContext())
            {
                roles = context.EH_Role.ToList();
            }
            masterResponse = new MasterResponse(roles, BaseResponse.ResponseStatus.Success);
            return masterResponse;
        }
    }
}