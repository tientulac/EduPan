using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponseVeMoi : ResponseBase
    {
        public List<RequestVeMoi> Data { get; set; }
    }
}