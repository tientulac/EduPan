using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;


namespace TemplateAPI.DAL
{
    public class PhuongPhapNghienCuuDAL
    {
        private LinqDataContext db;
        public PhuongPhapNghienCuuDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduPhuongPhapNghienCuu_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduPhuongPhapNghienCuu_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhuongPhapNghienCuu_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        public ISingleResult<sp_eduPhuongPhapNghienCuu_InsertResult> Insert(RequestPhuongPhapNghienCuu req)
        {
            ISingleResult<sp_eduPhuongPhapNghienCuu_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhuongPhapNghienCuu_Insert(req.Ten_phuong_phap,req.Ngay_tao,req.Trang_thai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduPhuongPhapNghienCuu_UpdateResult> Update(RequestPhuongPhapNghienCuu req)
        {
            ISingleResult<sp_eduPhuongPhapNghienCuu_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhuongPhapNghienCuu_Update(req.ID_phuong_phap,req.Ten_phuong_phap, req.Ngay_tao, req.Trang_thai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduPhuongPhapNghienCuu_DeleteResult> Delete(int ID_phuong_phap)
        {
            ISingleResult<sp_eduPhuongPhapNghienCuu_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhuongPhapNghienCuu_Delete(ID_phuong_phap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}