using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestKhoa 
    {
        public int ID_khoa { get; set; }
        public string Ma_khoa { get; set; }
        public string Ten_khoa { get; set; }
        public int ID_truong { get; set; }
        public string Ten_truong { get; set; }
    }
}