﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;

namespace TemplateAPI.CommonClass.Models.OutputModels
{
    public class ResponseHocBongSinhVien : ResponseBase
    {
        public List<RequestHocBongSinhVien> Data { get; set; }
    }
}