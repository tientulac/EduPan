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
    [RoutePrefix("ChuyenGiaPhongHop")]
    [AllowAnonymous]
    public class ChuyenGiaPhongHopController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        ChuyenGiaPhongHopDAL objChuyenGiaPH = new ChuyenGiaPhongHopDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseChuyenGiaPhongHop res = new ResponseChuyenGiaPhongHop();
            try
            {
                var lst = (from a in objChuyenGiaPH.Load_List()
                           select new RequestChuyenGiaPhongHop
                           {
                               ID_cg_ph = a.ID_cg_ph,
                               ID_phong_hop = a.ID_phong_hop.GetValueOrDefault(),
                               ID_chuyen_gia = a.ID_chuyen_gia.GetValueOrDefault(),
                               Hang = a.Hang.GetValueOrDefault(),
                               Cot = a.Cot.GetValueOrDefault(),
                               Trang_thai = a.Trang_thai.GetValueOrDefault(),
                               Ten_chuyen_gia = a.Ten_chuyen_gia,
                               Ten_phong = a.Ten_phong
                           }).ToList();
                res.Data = lst;
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


        [HttpPost]
        [Route("Insert")]
        public async Task<ResponseBase> Insert(RequestChuyenGiaPhongHop req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objChuyenGiaPH.Insert(req);
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Thêm mới thành công !";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Thêm thất bại !";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        [HttpGet]
        [Route("Delete")]
        public async Task<ResponseBase> Delete(int ID_cg_ph)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objChuyenGiaPH.Delete(ID_cg_ph);
                if (rs.FirstOrDefault().Deleted == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Xóa thành công !";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Xóa thất bại !";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }
    }
}