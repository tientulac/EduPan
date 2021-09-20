using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestVeMoiHoiThao
    {
        public int ID_ve_moi_hoi_thao { get; set; }
        public int ID_hoi_thao { get; set; }
        public int ID_ve_moi { get; set; }
        public int ID_chuyen_gia { get; set; }
    }
    public class RequestVeMoiHoiThaoDTO
    {
        public int ID_ve_moi_hoi_thao { get; set; }
        public int ID_hoi_thao { get; set; }
        public int ID_ve_moi { get; set; }
        public int ID_chuyen_gia { get; set; }
        public string Ten_hoi_thao { get; set; }
        public string Ten_ve { get; set; }
        public DateTime Ngay_bat_dau { get; set; }
        public DateTime Ngay_ket_thuc { get; set; }
        public string Ten_loai { get; set; }
        public string Ten_chuyen_gia { get; set; }
    }
}