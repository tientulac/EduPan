using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.Utils
{
    public class ResponseLogin : ResponseBase
    {
        public string Token { get; set; }
        public string TALoginCode { get; set; }
        public UserInfo Info { get; set; }
    }
}