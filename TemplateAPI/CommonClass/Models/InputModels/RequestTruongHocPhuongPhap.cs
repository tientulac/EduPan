using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestTruongHocPhuongPhap : RequestBase
    {
        public int ID_th_pp { get; set; }
        public int ID_phuong_phap { get; set; }
        public int ID_truong { get; set; }
        public string Ten_phuong_phap { get; set; }
        public DateTime? Ngay_tao { get; set; }
        public int Trang_thai { get; set; }
        public string Ten_trang_thai { get; set; }
        public string Ten_chuyen_gia { get; set; }
        public List<int> lst_ID_phuong_phap { get; set; }
    }
}