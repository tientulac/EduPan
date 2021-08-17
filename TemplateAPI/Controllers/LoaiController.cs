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
    [RoutePrefix("Loai")]
    [AllowAnonymous]
    public class LoaiController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        LoaiHocBongDAL objLoaiHB = new LoaiHocBongDAL();
        LoaiHoTroDAL objLoaiHT = new LoaiHoTroDAL();
        LoaiVeMoiDAL objLoaiVe = new LoaiVeMoiDAL();

        [HttpGet]
        [Route("LoaiHocBong_Load_List")]
        public async Task<HttpResponseMessage> LoaiHocBong_Load_List()
        {
            ResponseLoaiHocBong res = new ResponseLoaiHocBong();
            try
            {
                var lst = (from a in objLoaiHB.Load_List()
                           select new RequestLoaiHocBong
                           {
                               ID_loai_hoc_bong = a.ID_loai_hoc_bong,
                               Ten_loai_hoc_bong = a.Ten_loai_hoc_bong
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
        [Route("LoaiHocBong_Insert")]
        public async Task<ResponseBase> Insert(RequestLoaiHocBong req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objLoaiHB.Insert(req);
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
        [Route("LoaiHB_Update")]
        public async Task<ResponseBase> Update(RequestLoaiHocBong req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objLoaiHB.Update(req);
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
        [Route("LoaiHocBong_Delete")]
        public async Task<ResponseBase> Delete(int ID_loai)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objLoaiHB.Delete(ID_loai);
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