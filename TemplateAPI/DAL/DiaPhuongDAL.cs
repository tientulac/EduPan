using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;
namespace TemplateAPI.DAL
{
    public class DiaPhuongDAL
    {
        private LinqDataContext db;
        public DiaPhuongDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduDiaPhuong_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduDiaPhuong_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduDiaPhuong_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduDiaPhuong_InsertResult> Insert(RequestDiaPhuong req)
        {
            ISingleResult<sp_eduDiaPhuong_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduDiaPhuong_Insert(req.Ma_dia_phuong,req.Ten_dia_phuong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduDiaPhuong_UpdateResult> Update(RequestDiaPhuong req)
        {
            ISingleResult<sp_eduDiaPhuong_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduDiaPhuong_Update(req.ID_dia_phuong,req.Ma_dia_phuong, req.Ten_dia_phuong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduDiaPhuong_DeleteResult> Delete(int ID_dia_phuong)
        {
            ISingleResult<sp_eduDiaPhuong_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduDiaPhuong_Delete(ID_dia_phuong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}