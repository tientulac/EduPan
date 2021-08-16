using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestCongTrinhNghienCuu : RequestBase
    {
        public int ID_cong_trinh { get; set; }
        public string Ten_cong_trinh { get; set; }
        public DateTime? Ngay_tao { get; set; }
        public int Trang_thai { get; set; }
        public string Ten_trang_thai { get; set; }
    }
}