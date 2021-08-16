using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestChuyenGia : RequestBase
    {
        public int ID_chuyen_gia { get; set; }
        public int ID_hoc_ham { get; set; }
        public int ID_hoc_vi {get;set;}
        public bool Gioi_tinh { get; set; }
        public DateTime? Ngay_sinh { get; set; }
        public int ID_phuong_phap { get; set; }
        public int ID_cong_trinh { get; set; }
        public string Ten_phuong_phap { get; set; }
        public string Ten_cong_trinh { get; set; }
    }
}