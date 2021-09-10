using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class HoiThaoDAL
    {
        private LinqDataContext db;
        public HoiThaoDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduHoiThao_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduHoiThao_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduHoiThao_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduHoiThao_InsertResult> Insert(RequestHoiThao req)
        {
            ISingleResult<sp_eduHoiThao_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduHoiThao_Insert(req.Ten_hoi_thao,req.Ngay_bat_dau,req.Ngay_ket_thuc,req.Dia_chi,req.Nguoi_to_chuc,req.So_luong_ve_moi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduHoiThao_UpdateResult> Update(RequestHoiThao req)
        {
            ISingleResult<sp_eduHoiThao_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduHoiThao_Update(req.ID_hoi_thao, req.Ten_hoi_thao, req.Ngay_bat_dau, req.Ngay_ket_thuc, req.Dia_chi, req.Nguoi_to_chuc, req.So_luong_ve_moi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduHoiThao_DeleteResult> Delete(int ID_hoi_thao)
        {
            ISingleResult<sp_eduHoiThao_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduHoiThao_Delete(ID_hoi_thao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}