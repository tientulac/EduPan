using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class TruongHocCongTrinhDAL
    {
        private LinqDataContext db;
        public TruongHocCongTrinhDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduTruongHoc_CongTrinhNC_Load_ListResult> Load_List(int ID_truong)
        {
            ISingleResult<sp_eduTruongHoc_CongTrinhNC_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_CongTrinhNC_Load_List(ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTruongHoc_CongTrinhNC_InsertResult> Insert(int ID_cong_trinh,int ID_truong)
        {
            ISingleResult<sp_eduTruongHoc_CongTrinhNC_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_CongTrinhNC_Insert(ID_cong_trinh, ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTruongHoc_CongTrinhNC_DeleteResult> Delete(int ID_th_ct)
        {
            ISingleResult<sp_eduTruongHoc_CongTrinhNC_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_CongTrinhNC_Delete(ID_th_ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}