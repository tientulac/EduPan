﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponsePhuongPhapNghienCuu : ResponseBase 
    {
        public List<RequestPhuongPhapNghienCuu> Data { get; set; }
    }
}