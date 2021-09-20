using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestUser : RequestBase
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? Admin { get; set; }
        public bool? Active { get; set; }
        public string Email { get; set; }
        public string Trang_thai { get; set; }
        public string Type_account { get; set; }
    }
}