using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class DanhSachHoTroDAL
    {
        private LinqDataContext db;
        public DanhSachHoTroDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<eduDanhSachHoTro_Load_ListResult> Load_List()
        {
            ISingleResult<eduDanhSachHoTro_Load_ListResult> sp_result;
            try
            {
                sp_result = db.eduDanhSachHoTro_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<eduDanhSachHoTro_INSERTResult> Insert(RequestDanhSachHoTro req)
        {
            ISingleResult<eduDanhSachHoTro_INSERTResult> sp_result;
            try
            {
                sp_result = db.eduDanhSachHoTro_INSERT(req.ID_loai,req.ID_dia_phuong,req.So_luong,req.Trang_thai_duyet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<eduDanhSachHoTro_UpdateResult> Update(RequestDanhSachHoTro req)
        {
            ISingleResult<eduDanhSachHoTro_UpdateResult> sp_result;
            try
            {
                sp_result = db.eduDanhSachHoTro_Update(req.ID_ho_tro,req.ID_loai, req.ID_dia_phuong, req.So_luong, req.Trang_thai_duyet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<eduDanhSachHoTro_DeleteResult> Delete(int ID_ho_tro)
        {
            ISingleResult<eduDanhSachHoTro_DeleteResult> sp_result;
            try
            {
                sp_result = db.eduDanhSachHoTro_Delete(ID_ho_tro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}