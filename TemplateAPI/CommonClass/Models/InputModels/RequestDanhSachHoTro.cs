using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestDanhSachHoTro : RequestBase
    {
        public int ID_ho_tro { get; set; }
        public int ID_loai { get; set; }
        public int ID_dia_phuong { get; set; }
        public int So_luong { get; set; }
        public bool Trang_thai_duyet { get; set; }
        public string Ten_dia_phuong { get; set; }
        public string Ten_loai { get; set; }
    }
}