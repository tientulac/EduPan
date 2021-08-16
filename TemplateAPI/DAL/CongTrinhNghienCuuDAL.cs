using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class CongTrinhNghienCuuDAL
    {
        private LinqDataContext db;
        public CongTrinhNghienCuuDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduCongTrinhNghienCuu_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduCongTrinhNghienCuu_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduCongTrinhNghienCuu_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduCongTrinhNghienCuu_InsertResult> Insert(RequestCongTrinhNghienCuu req)
        {
            ISingleResult<sp_eduCongTrinhNghienCuu_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduCongTrinhNghienCuu_Insert(req.Ten_cong_trinh,req.Ngay_tao,req.Trang_thai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduCongTrinhNghienCuu_UpdateResult> Update(RequestCongTrinhNghienCuu req)
        {
            ISingleResult<sp_eduCongTrinhNghienCuu_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduCongTrinhNghienCuu_Update(req.ID_cong_trinh,req.Ten_cong_trinh, req.Ngay_tao, req.Trang_thai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduCongTrinhNghienCuu_DeleteResult> Delete(int ID_cong_trinh)
        {
            ISingleResult<sp_eduCongTrinhNghienCuu_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduCongTrinhNghienCuu_Delete(ID_cong_trinh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}