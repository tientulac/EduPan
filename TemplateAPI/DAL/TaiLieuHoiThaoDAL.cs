using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class TaiLieuHoiThaoDAL
    {
        private LinqDataContext db;
        public  TaiLieuHoiThaoDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduTaiLieuHoiThao_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduTaiLieuHoiThao_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduTaiLieuHoiThao_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTaiLieuHoiThao_InsertResult> Insert(RequestTaiLieuHoiThao req)
        {
            ISingleResult<sp_eduTaiLieuHoiThao_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduTaiLieuHoiThao_Insert(req.Ten_tai_lieu, req.Mo_ta, req.ID_hoi_thao, req.FileName, req.Url, req.DocType, req.FileDoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTaiLieuHoiThao_DeleteResult> Delete(int ID_tai_lieu)
        {
            ISingleResult<sp_eduTaiLieuHoiThao_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduTaiLieuHoiThao_Delete(ID_tai_lieu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

    }
}