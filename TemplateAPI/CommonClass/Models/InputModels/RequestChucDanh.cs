using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestChucDanh : RequestBase
    {
        public class HocHam
        {
            public int ID_hoc_ham { get; set; }
            public string Ten_hoc_ham { get; set; }
        }
        public class HocVi
        {
            public int ID_hoc_vi { get; set; }
            public string Ten_hoc_vi { get; set; }
        }
    }
}