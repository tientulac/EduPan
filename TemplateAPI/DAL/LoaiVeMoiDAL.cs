using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class LoaiVeMoiDAL
    {
        private LinqDataContext db;
        public LoaiVeMoiDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduLoaiVeMoi_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduLoaiVeMoi_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduLoaiVeMoi_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}