using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestVeMoi : RequestBase
    {
        public int ID_ve_moi { get; set; }
        public string Ten_ve { get; set; }
        public DateTime? Ngay_bat_dau { get; set; }
        public DateTime? Ngay_ket_thuc { get; set; }
        public int ID_loai { get; set; }
    }
}