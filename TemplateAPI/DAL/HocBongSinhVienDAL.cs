using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class HocBongSinhVienDAL
    {
        private LinqDataContext db;
        public HocBongSinhVienDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduHocBongSinhVien_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduHocBongSinhVien_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduHocBongSinhVien_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<eduHocBongSinhVien_InsertResult> Insert(RequestHocBongSinhVien req)
        {
            ISingleResult<eduHocBongSinhVien_InsertResult> sp_result;
            try
            {
                sp_result = db.eduHocBongSinhVien_Insert(req.ID_loai,req.Ten_hoc_bong,req.Ngay_cap,req.Trang_thai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<eduHocBongSinhVien_UpdateResult> Update(RequestHocBongSinhVien req)
        {
            ISingleResult<eduHocBongSinhVien_UpdateResult> sp_result;
            try
            {
                sp_result = db.eduHocBongSinhVien_Update(req.ID_hb_sv,req.ID_loai, req.Ten_hoc_bong, req.Ngay_cap, req.Trang_thai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}