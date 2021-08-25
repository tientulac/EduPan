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
    [RoutePrefix("DanhSachHoTro")]
    [AllowAnonymous]
    public class DanhSachHoTroController : ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        DanhSachHoTroDAL objDSHoTro = new DanhSachHoTroDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseDanhSachHoTro res = new ResponseDanhSachHoTro();
            try
            {
                var lst = (from a in objDSHoTro.Load_List()
                           select new RequestDanhSachHoTro
                           {
                               ID_ho_tro = a.ID_ho_tro,
                               ID_loai = a.ID_loai.GetValueOrDefault(),
                               ID_dia_phuong = a.ID_dia_phuong.GetValueOrDefault(),
                               So_luong = a.So_luong.GetValueOrDefault(),
                               Trang_thai_duyet = a.Trang_thai_duyet.GetValueOrDefault(),
                               Ten_dia_phuong = a.Ten_dia_phuong,
                               Ten_loai = a.Ten_loai,
                               Ten_trang_thai = a.Trang_thai_duyet == true ? "Đã duyệt" : "Chờ duyệt",
                               Ten_don_vi = a.Ten_loai.Contains("thực phẩm") ? string.Format("{0} (kg)",a.So_luong) : a.So_luong.ToString() 
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
        public async Task<ResponseBase> Insert(RequestDanhSachHoTro req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objDSHoTro.Insert(req);
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
        public async Task<ResponseBase> Update(RequestDanhSachHoTro req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objDSHoTro.Update(req);
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
        public async Task<ResponseBase> Delete(int ID_ho_tro)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objDSHoTro.Delete(ID_ho_tro);
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