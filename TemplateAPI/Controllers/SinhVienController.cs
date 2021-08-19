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
    [RoutePrefix("SinhVien")]
    [AllowAnonymous]
    public class SinhVienController : ApiController
    {
        SinhVienDAL objSinhVien = new SinhVienDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseSinhVien res = new ResponseSinhVien();
            try
            {
                var lst = (from a in objSinhVien.Load_List()
                           select new RequestSinhVien
                           {
                               ID_sinh_vien = a.ID_sinh_vien,
                               Ho_ten = a.Ho_ten,
                               So_dien_thoai = a.So_dien_thoai,
                               Dia_chi = a.Dia_chi,
                               Email = a.Email,
                               CCCD = a.CCCD,
                               Gioi_tinh = a.Gioi_tinh.GetValueOrDefault(),
                               Ngay_sinh = a.Ngay_sinh,
                               ID_truong = a.ID_truong.GetValueOrDefault(),
                               Ten_truong = a.Ten_truong,
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
        public async Task<ResponseBase> Insert(RequestSinhVien req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objSinhVien.Insert(req);
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
        public async Task<ResponseBase> Update(RequestSinhVien req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objSinhVien.Update(req);
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
        public async Task<ResponseBase> Delete(int ID_sinh_vien)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objSinhVien.Delete(ID_sinh_vien);
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