﻿using System;
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
        public string Ten_trang_thai { get; set; }
        public string Ten_don_vi { get; set; }
        public double Thoi_gian_quyen_gop { get; set; }
        public decimal So_tien_mong_muon { get; set; }
        public decimal So_tien_ung_ho { get; set; }
    }
}