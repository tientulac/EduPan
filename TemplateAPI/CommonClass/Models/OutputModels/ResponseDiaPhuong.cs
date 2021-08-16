using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponseDiaPhuong : ResponseBase
    {
        public List<RequestDiaPhuong> Data { get; set; }
    }
}