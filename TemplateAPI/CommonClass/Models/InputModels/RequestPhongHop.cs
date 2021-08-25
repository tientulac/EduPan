using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestPhongHop : RequestBase
    {
        public int ID_phong_hop { get; set; }
        public string Ma_phong { get; set; }
        public string Ten_phong { get; set; }
        public int Suc_chua { get; set; }
        public int So_hang { get; set; }
        public int So_cot { get; set; }
        public int ID_hoi_thao { get; set; }
        public string Ten_hoi_thao { get; set; }
    }
}