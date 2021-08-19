using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class ChuyenGiaDAL
    {
        private LinqDataContext db;
        public ChuyenGiaDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduChuyenGia_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduChuyenGia_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGia_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduChuyenGia_InsertResult> Insert(RequestChuyenGia req)
        {
            ISingleResult<sp_eduChuyenGia_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGia_Insert(req.Ten_chuyen_gia,req.ID_hoc_ham, req.ID_hoc_vi, req.Gioi_tinh, req.Ngay_sinh, req.ID_phuong_phap, req.ID_cong_trinh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduChuyenGia_UPDATEResult> Update(RequestChuyenGia req)
        {
            ISingleResult<sp_eduChuyenGia_UPDATEResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGia_UPDATE(req.Ten_chuyen_gia,req.ID_chuyen_gia,req.ID_hoc_ham, req.ID_hoc_vi, req.Gioi_tinh, req.Ngay_sinh, req.ID_phuong_phap, req.ID_cong_trinh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduChuyenGia_DeleteResult> Delete(int ID_chuyen_gia)
        {
            ISingleResult<sp_eduChuyenGia_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGia_Delete(ID_chuyen_gia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}