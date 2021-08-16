using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class HocViDAL
    {
        private LinqDataContext db;
        public HocViDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_eduHocVi_Load_ListResult> Load_List()
        {
            ISingleResult<sp_eduHocVi_Load_ListResult> sp_result;
            try
            {
                sp_result = db.sp_eduHocVi_Load_List();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}