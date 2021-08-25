using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestChuyenGiaPhongHop : RequestBase
    {
        public int ID_cg_ph { get; set; }
        public int ID_phong_hop { get; set; }
        public int ID_chuyen_gia { get;set; }
        public int Hang { get; set; }
        public int Cot { get; set; }
        public bool Trang_thai { get; set; }
        public string Ten_chuyen_gia { get; set; }
        public string Ten_phong { get; set; }
    }
}