using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestTaiLieuHoiThao : RequestBase
    {
        public int ID_tai_lieu { get; set; }
        public string Ten_tai_lieu { get; set; }
        public string Mo_ta { get; set; }
        public int ID_hoi_thao { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string DocType { get; set; }
        public string FileDoc { get; set; }
        public string fileBase64 { get; set; }
    }
}