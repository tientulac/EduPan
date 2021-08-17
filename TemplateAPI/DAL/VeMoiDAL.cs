using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class VeMoiDAL
    {
        private LinqDataContext db;
        public VeMoiDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduVeMoi_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduVeMoi_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoi_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        public ISingleResult<sp_eduVeMoi_InsertResult> Insert(RequestVeMoi req)
        {
            ISingleResult<sp_eduVeMoi_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoi_Insert(req.Ten_ve,req.Ngay_bat_dau,req.Ngay_ket_thuc,req.ID_loai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduVeMoi_UpdateResult> Update(RequestVeMoi req)
        {
            ISingleResult<sp_eduVeMoi_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoi_Update(req.ID_ve_moi,req.Ten_ve, req.Ngay_bat_dau, req.Ngay_ket_thuc, req.ID_loai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduVeMoi_DeleteResult> Delete(int ID_ve_moi)
        {
            ISingleResult<sp_eduVeMoi_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoi_Delete(ID_ve_moi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}