using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class LoaiHocBongDAL
    {
        private LinqDataContext db;
        public LoaiHocBongDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduLoaiHocBong_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduLoaiHocBong_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduLoaiHocBong_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduLoaiHocBong_InsertResult> Insert(RequestLoaiHocBong req)
        {
            ISingleResult<sp_eduLoaiHocBong_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduLoaiHocBong_Insert(req.Ten_loai_hoc_bong,req.Gia_tri,req.Nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduLoaiHocBong_UpdateResult> Update(RequestLoaiHocBong req)
        {
            ISingleResult<sp_eduLoaiHocBong_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduLoaiHocBong_Update(req.ID_loai_hoc_bong,req.Ten_loai_hoc_bong, req.Gia_tri, req.Nam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduLoaiHocBong_DeleteResult> Delete(int ID_loai_hoc_bong)
        {
            ISingleResult<sp_eduLoaiHocBong_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduLoaiHocBong_Delete(ID_loai_hoc_bong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}