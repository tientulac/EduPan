using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestTruongHoc : RequestBase
    {
        public int ID_truong { get; set; }
        public string Ma_truong { get; set; }
        public string Ten_truong { get; set; }
        public string Dia_chi { get; set; }
    }
}