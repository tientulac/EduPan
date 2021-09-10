using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;


namespace TemplateAPI.DAL
{
    public class SinhVienDAL
    {
        private LinqDataContext db;
        public SinhVienDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduSinhVien_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduSinhVien_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduSinhVien_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        public ISingleResult<sp_eduSinhVien_InsertResult> Insert(RequestSinhVien req)
        {
            ISingleResult<sp_eduSinhVien_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduSinhVien_Insert(req.Ho_ten,req.Dia_chi,req.Email,req.So_dien_thoai,req.CCCD,req.Gioi_tinh,req.Ngay_sinh,req.ID_khoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduSinhVien_UpdateResult> Update(RequestSinhVien req)
        {
            ISingleResult<sp_eduSinhVien_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduSinhVien_Update(req.ID_sinh_vien,req.Ho_ten, req.Dia_chi, req.Email, req.So_dien_thoai, req.CCCD, req.Gioi_tinh, req.Ngay_sinh, req.ID_khoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduSinhVien_DeleteResult> Delete(int ID_phuong_phap)
        {
            ISingleResult<sp_eduSinhVien_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduSinhVien_Delete(ID_phuong_phap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}