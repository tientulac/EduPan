using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class TrungTamDAL
    {
        private LinqDataContext db;
        public TrungTamDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduTrungTam_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduTrungTam_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduTrungTam_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        public ISingleResult<sp_eduTrungTam_InsertResult> Insert(RequestTrungTam req)
        {
            ISingleResult<sp_eduTrungTam_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduTrungTam_Insert(req.Ma_trung_tam,req.Ten_trung_tam,req.Dia_chi,req.So_dien_thoai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTrungTam_UpdateResult> Update(RequestTrungTam req)
        {
            ISingleResult<sp_eduTrungTam_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduTrungTam_Update(req.ID_trung_tam,req.Ma_trung_tam, req.Ten_trung_tam, req.Dia_chi, req.So_dien_thoai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTrungTam_DeleteResult> Delete(int ID_trung_tam)
        {
            ISingleResult<sp_eduTrungTam_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduTrungTam_Delete(ID_trung_tam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}