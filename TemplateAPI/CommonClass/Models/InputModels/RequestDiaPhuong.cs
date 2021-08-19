using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestDiaPhuong : RequestBase
    {
        public int ID_dia_phuong { get; set; }
        public string Ma_dia_phuong { get; set; }
        public string Ten_dia_phuong { get; set; }
    }
}