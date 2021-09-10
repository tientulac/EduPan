using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class KhoaDAL
    {
        private LinqDataContext db;
        public KhoaDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduKhoa_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduKhoa_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduKhoa_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduKhoa_InsertResult> Insert(RequestKhoa req)
        {
            ISingleResult<sp_eduKhoa_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduKhoa_Insert(req.Ma_khoa,req.Ten_khoa,req.ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduKhoa_UpdateResult> Update(RequestKhoa req)
        {
            ISingleResult<sp_eduKhoa_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduKhoa_Update(req.ID_khoa,req.Ma_khoa, req.Ten_khoa, req.ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduChuyenGia_DeleteResult> Delete(int ID_khoa)
        {
            ISingleResult<sp_eduChuyenGia_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGia_Delete(ID_khoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}