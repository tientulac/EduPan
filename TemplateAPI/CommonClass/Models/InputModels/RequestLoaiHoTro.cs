using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestLoaiHoTro : RequestBase
    {
        public int ID_loai { get; set; }
        public string Ten_loai { get; set; }
    }
}