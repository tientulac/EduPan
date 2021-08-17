using CommonClass.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using TemplateAPI.Common;
using TemplateAPI.CommonClass.Models;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.CommonClass.Models.OutputModels;
using TemplateAPI.CommonClass.Models.Utils;
using TemplateAPI.DAL;
using TemplateAPI.Models;

namespace TemplateAPI.Controllers
{
    [RoutePrefix("ChucDanh")]
    [AllowAnonymous]
    public class ChucDanhController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        HocHamDAL objHocHam = new HocHamDAL();
        HocViDAL objHocVi = new HocViDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            var res = new ResponseChucDanh();
            try
            {
                var lst_hh = (from a in objHocHam.Load_List()
                           select new RequestChucDanh.HocHam
                           {
                              ID_hoc_ham = a.ID_hoc_ham,
                              Ten_hoc_ham = a.Ten_hoc_ham
                           }).ToList();
                var lst_hv = (from a in objHocVi.Load_List()
                              select new RequestChucDanh.HocVi
                              {
                                  ID_hoc_vi = a.ID_hoc_vi,
                                  Ten_hoc_vi = a.Ten_hoc_vi
                              }).ToList();
                res.Data1 = lst_hh;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }

            var stringdata = JsonConvert.SerializeObject(res);

            var responseResult = new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };

            return await Task.FromResult(responseResult);
        }
    }
}