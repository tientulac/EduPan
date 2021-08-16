using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestHoiThao : RequestBase
    {
        public int ID_hoi_thao { get; set; }
        public string Ten_hoi_thao { get; set; }
        public DateTime? Ngay_bat_dau { get; set; }
        public DateTime? Ngay_ket_thuc { get; set; }
    }
}