using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestLoaiHocBong : RequestBase
    {
        public int ID_loai_hoc_bong { get; set; }
        public string Ten_loai_hoc_bong { get; set; }
        public decimal Gia_tri { get; set; }
        public int Nam { get; set; }
    }
}