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
    [RoutePrefix("ChuyenGia")]
    [AllowAnonymous]
    public class ChuyenGiaController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        ChuyenGiaDAL objChuyenGia = new ChuyenGiaDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseChuyenGia res = new ResponseChuyenGia();
            try
            {
                var lst = (from a in objChuyenGia.Load_List()
                           select new RequestChuyenGia
                           {
                               ID_chuyen_gia = a.ID_chuyen_gia,
                               Ten_chuyen_gia = a.Ten_chuyen_gia,
                               ID_hoc_ham = a.ID_hoc_ham.GetValueOrDefault(),
                               ID_hoc_vi = a.ID_hoc_vi.GetValueOrDefault(),
                               Gioi_tinh = a.Gioi_tinh.GetValueOrDefault(),
                               Ngay_sinh = a.Ngay_sinh,
                               ID_phuong_phap = a.ID_phuong_phap.GetValueOrDefault(),
                               ID_cong_trinh = a.ID_cong_trinh.GetValueOrDefault(),
                               Ten_phuong_phap = a.Ten_phuong_phap,
                               Ten_cong_trinh = a.Ten_cong_trinh,
                               Ten_hoc_ham = a.Ten_hoc_ham,
                               Ten_hoc_vi = a.Ten_hoc_vi,
                               Ten_gioi_tinh = a.Gioi_tinh == true ? "Nam" : "Nữ"
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
        public async Task<ResponseBase> Insert(RequestChuyenGia req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objChuyenGia.Insert(req);
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
        public async Task<ResponseBase> Update(RequestChuyenGia req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objChuyenGia.Update(req);
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
        public async Task<ResponseBase> Delete(int ID_chuyen_gia)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objChuyenGia.Delete(ID_chuyen_gia);
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