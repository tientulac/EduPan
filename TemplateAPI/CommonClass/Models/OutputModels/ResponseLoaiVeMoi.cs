using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponseLoaiVeMoi : ResponseBase
    {
        public List<ResponseLoaiVeMoi> Data { get; set; }
    }
}