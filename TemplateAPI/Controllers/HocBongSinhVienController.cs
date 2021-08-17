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
    [RoutePrefix("HocBongSinhVien")]
    [AllowAnonymous]
    public class HocBongSinhVienController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        HocBongSinhVienDAL objHBSV = new HocBongSinhVienDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseHocBongSinhVien res = new ResponseHocBongSinhVien();
            try
            {
                var lst = (from a in objHBSV.Load_List()
                           select new RequestHocBongSinhVien
                           {
                               ID_hb_sv = a.ID_hb_sv,
                               ID_loai = a.ID_loai.GetValueOrDefault(),
                               Ten_hoc_bong = a.Ten_hoc_bong,
                               Ngay_cap = a.Ngay_cap,
                               Trang_thai = a.Trang_thai.GetValueOrDefault(),
                               Ten_trang_thai = a.Trang_thai == 1 ? "Đã duyệt" : a.Trang_thai == 2 ? "Chờ duyệt" : "Đã chuyển đến sinh viên",
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
        [Route("Insert")]
        public async Task<ResponseBase> Insert(RequestHocBongSinhVien req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objHBSV.Insert(req);
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
        public async Task<ResponseBase> Update(RequestHocBongSinhVien req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objHBSV.Update(req);
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
        public async Task<ResponseBase> Delete(int ID_hb_sv)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objHBSV.Delete(ID_hb_sv);
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