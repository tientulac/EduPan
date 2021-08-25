using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class ChuyenGiaPhongHopDAL
    {
        private LinqDataContext db;
        public ChuyenGiaPhongHopDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduChuyenGiaPhongHop_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduChuyenGiaPhongHop_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGiaPhongHop_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduChuyenGiaPhongHop_InsertResult> Insert(RequestChuyenGiaPhongHop req)
        {
            ISingleResult<sp_eduChuyenGiaPhongHop_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGiaPhongHop_Insert(req.ID_phong_hop,req.ID_chuyen_gia,req.Hang,req.Cot,true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_eduChuyenGiaPhongHop_DeleteResult> Delete(int ID_cg_ph)
        {
            ISingleResult<sp_eduChuyenGiaPhongHop_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_eduChuyenGiaPhongHop_Delete(ID_cg_ph);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}