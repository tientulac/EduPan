﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponseLoaiHocBong : ResponseBase
    {
        public List<RequestLoaiHocBong> Data { get; set; }
    }
}