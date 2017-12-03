using BackendBO.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendBO.Response
{
    public class PersonResponse : BaseResponse
    {
        public EH_Person Person { get; set; }
        public List<EH_Person> Persons { get; set; }

        public PersonResponse()
        {
        }

        /// <summary>
        /// initialize constructor with values
        /// </summary>      
        /// <param name="responseStatus"></param>
        public PersonResponse(BaseResponse.ResponseStatus responseStatus_)
            : base(responseStatus_)
        {

        }

        /// <summary>
        /// initialize constructor with values
        /// </summary>
        /// <param name="person_"></param>
        /// <param name="responseStatus_"></param>
        public PersonResponse(EH_Person person_, ResponseStatus responseStatus_)
            : base(responseStatus_)
        {
            Person = person_;
        }

        /// <summary>
        /// initialize constructor with values
        /// </summary>
        /// <param name="persons_"></param>
        /// <param name="responseStatus_"></param>
        public PersonResponse(List<EH_Person> persons_, ResponseStatus responseStatus_)
            : base(responseStatus_)
        {
            Persons = persons_;
        }
    }
}