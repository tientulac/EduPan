using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.Utils
{
    public class RequestLogin : RequestBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TALoginCode { get; set; }
        public int ID_ph { get; set; }
    }
}