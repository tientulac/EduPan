using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;


namespace TemplateAPI.DAL
{
    public class TruongHocDAL
    {
        private LinqDataContext db;
        public TruongHocDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduTruongHoc_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduTruongHoc_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        public ISingleResult<sp_eduTruongHoc_InsertResult> Insert(RequestTruongHoc req)
        {
            ISingleResult<sp_eduTruongHoc_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_Insert(req.Ma_truong,req.Ten_truong,req.Dia_chi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTruongHoc_UpdateResult> Update(RequestTruongHoc req)
        {
            ISingleResult<sp_eduTruongHoc_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_Update(req.ID_truong,req.Ma_truong, req.Ten_truong, req.Dia_chi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTruongHoc_DeleteResult> Delete(int ID_truong)
        {
            ISingleResult<sp_eduTruongHoc_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_Delete(ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}