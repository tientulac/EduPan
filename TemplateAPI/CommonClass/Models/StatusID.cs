using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models
{
    public enum StatusID
    {
        Success = 1,
        InternalServer,
        TokenInvalid,
        IDNotFound,
        BadRequest,
        ServerBusy,
        AccessDenied,
        AlreadyExist,
        NotExisted
    }
}