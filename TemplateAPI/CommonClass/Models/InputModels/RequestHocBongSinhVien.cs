﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateAPI.CommonClass.Models.InputModels
{
    public class RequestHocBongSinhVien : RequestBase
    {
        public int ID_hb_sv { get; set; }
        public int ID_loai { get; set; }
        public string Ten_hoc_bong { get; set; }
        public DateTime? Ngay_cap { get; set; }
        public int Trang_thai { get; set; }
        public string Ten_trang_thai { get; set; }
        public string Ten_loai_hoc_bong { get; set; }
        public int ID_sinh_vien { get; set; }
        public string Ho_ten { get; set; }
        public decimal Gia_tri_max { get; set; }
        public DateTime Ngay_het_han { get; set; }
    }
}