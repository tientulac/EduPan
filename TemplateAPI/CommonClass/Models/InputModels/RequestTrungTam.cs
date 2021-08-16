using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestTrungTam : RequestBase
    {
        public int ID_trung_tam { get; set; }
        public string Ma_trung_tam { get; set; }
        public string Ten_trung_tam { get; set; }
        public string Dia_chi { get; set; }
        public string So_dien_thoai { get; set; }
    }
}