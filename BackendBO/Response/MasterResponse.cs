//using BackendDAL.Data;
using BackendBO.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendBO.Response
{
    public class MasterResponse : BaseResponse
    {
        public EH_Role Role { get; set; }
        public List<EH_Role> Roles { get; set; }

        public MasterResponse()
        {
        }

        /// <summary>
        /// initialize constructor with values
        /// </summary>      
        /// <param name="responseStatus"></param>
        public MasterResponse(BaseResponse.ResponseStatus responseStatus)
            : base(responseStatus)
        {

        }

        /// <summary>
        /// initialize constructor with values
        /// </summary>
        /// <param name="masterList"></param>
        /// <param name="Region"></param>
        /// <param name="message"></param>
        public MasterResponse(List<EH_Role> roles_, ResponseStatus responseStatus_)
            : base(responseStatus_)
        {
            Roles = roles_;
        }
    }
}