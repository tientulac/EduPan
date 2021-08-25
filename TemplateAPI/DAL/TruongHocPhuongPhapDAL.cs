using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class TruongHocPhuongPhapDAL
    {
        private LinqDataContext db;
        public TruongHocPhuongPhapDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduTruongHoc_PhuongPhapNC_Load_ListResult> Load_List(int ID_truong)
        {
            ISingleResult<sp_eduTruongHoc_PhuongPhapNC_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_PhuongPhapNC_Load_List(ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTruongHoc_PhuongPhapNC_InsertResult> Insert(int ID_phuong_phap,int ID_truong)
        {
            ISingleResult<sp_eduTruongHoc_PhuongPhapNC_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_PhuongPhapNC_Insert(ID_phuong_phap, ID_truong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduTruongHoc_PhuongPhapNC_DeleteResult> Delete(int ID_th_pp)
        {
            ISingleResult<sp_eduTruongHoc_PhuongPhapNC_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduTruongHoc_PhuongPhapNC_Delete(ID_th_pp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}