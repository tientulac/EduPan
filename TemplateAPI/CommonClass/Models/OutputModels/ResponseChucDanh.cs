using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponseChucDanh : ResponseBase
    {
        public List<RequestChucDanh.HocHam> Data1 { get; set; }
        public List<RequestChucDanh.HocVi> Data2 { get; set; }
    }
}