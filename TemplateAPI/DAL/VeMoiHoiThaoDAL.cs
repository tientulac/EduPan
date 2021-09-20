using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class VeMoiHoiThaoDAL
    {
        private LinqDataContext db;
        public VeMoiHoiThaoDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduVeMoiHoiThao_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduVeMoiHoiThao_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoiHoiThao_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduVeMoiHoiThao_InsertResult> Insert(RequestVeMoiHoiThao req)
        {
            ISingleResult<sp_eduVeMoiHoiThao_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoiHoiThao_Insert(req.ID_hoi_thao,req.ID_ve_moi,req.ID_chuyen_gia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduVeMoiHoiThao_UpdateResult> Update(RequestVeMoiHoiThao req)
        {
            ISingleResult<sp_eduVeMoiHoiThao_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoiHoiThao_Update(req.ID_ve_moi_hoi_thao,req.ID_hoi_thao, req.ID_ve_moi, req.ID_chuyen_gia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduVeMoiHoiThao_DeleteResult> Delete(int ID_ve_moi_hoi_thao)
        {
            ISingleResult<sp_eduVeMoiHoiThao_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduVeMoiHoiThao_Delete(ID_ve_moi_hoi_thao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}