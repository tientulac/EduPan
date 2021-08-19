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
    [RoutePrefix("DiaPhuong")]
    [AllowAnonymous]
    public class DiaPhuongController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        DiaPhuongDAL objDiaPhuong = new DiaPhuongDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseDiaPhuong res = new ResponseDiaPhuong();
            try
            {
                var lst = (from a in objDiaPhuong.Load_List()
                           select new RequestDiaPhuong
                           {
                               ID_dia_phuong = a.ID_dia_phuong,
                               Ma_dia_phuong = a.Ma_dia_phuong,
                               Ten_dia_phuong = a.Ten_dia_phuong
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
        public async Task<ResponseBase> Insert(RequestDiaPhuong req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objDiaPhuong.Insert(req);
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

        [HttpPost]
        [Route("Update")]
        public async Task<ResponseBase> Update(RequestDiaPhuong req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objDiaPhuong.Update(req);
                if (rs.FirstOrDefault().Updated == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Cập nhật thành công !";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Cập nhật thất bại !";
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
        public async Task<ResponseBase> Delete(int ID_dia_phuong)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objDiaPhuong.Delete(ID_dia_phuong);
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