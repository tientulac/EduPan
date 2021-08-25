using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class PhongHopDAL
    {
        private LinqDataContext db;
        public PhongHopDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduPhongHop_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduPhongHop_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhongHop_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduPhongHop_InsertResult> Insert(RequestPhongHop req)
        {
            ISingleResult<sp_eduPhongHop_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhongHop_Insert(req.Ma_phong,req.Ten_phong,req.Suc_chua,req.So_hang,req.So_cot,req.ID_hoi_thao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduPhongHop_UpdateResult> Update(RequestPhongHop req)
        {
            ISingleResult<sp_eduPhongHop_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhongHop_Update(req.ID_phong_hop,req.Ma_phong, req.Ten_phong, req.Suc_chua, req.So_hang, req.So_cot, req.ID_hoi_thao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduPhongHop_DeleteResult> Delete(int ID_phong_hop)
        {
            ISingleResult<sp_eduPhongHop_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduPhongHop_Delete(ID_phong_hop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}