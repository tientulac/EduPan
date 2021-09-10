using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestSinhVien : RequestBase
    {
        public int ID_sinh_vien { get; set; }
        public string Ho_ten { get; set; }
        public string Dia_chi { get; set; }
        public string Email { get; set; }
        public string So_dien_thoai { get; set; }
        public string CCCD { get; set; }
        public bool Gioi_tinh { get; set; }
        public DateTime? Ngay_sinh { get; set; }
        public int ID_truong { get; set; }
        public string Ten_truong { get; set; }
        public string Ten_gioi_tinh { get; set; }
        public int Count_hoc_bong { get; set; }
        public string Ngay_cap { get; set; }
        public int ID_khoa { get; set; }
        public string Ten_khoa { get; set; }

    }
}