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
    [RoutePrefix("VeMoiHoiThao")]
    [AllowAnonymous]
    public class VeMoiHoiThaoController: ApiController
    {
        private LinqDataContext db = new LinqDataContext();
        VeMoiHoiThaoDAL objVeMoiHoiThao = new VeMoiHoiThaoDAL();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseVeMoiHoiThao res = new ResponseVeMoiHoiThao();
            try
            {
                var lst = (from a in objVeMoiHoiThao.Load_List()
                           orderby a.Ngay_ket_thuc ascending
                           select new RequestVeMoiHoiThaoDTO
                           {
                               ID_ve_moi_hoi_thao = a.ID_ve_moi_hoi_thao,
                               ID_hoi_thao = a.ID_hoi_thao.GetValueOrDefault(),
                               ID_ve_moi = a.ID_ve_moi.GetValueOrDefault(),
                               ID_chuyen_gia = a.ID_chuyen_gia.GetValueOrDefault(),
                               Ten_hoi_thao = a.Ten_hoi_thao,
                               Ten_ve = a.Ten_ve,
                               Ngay_bat_dau = a.Ngay_bat_dau.GetValueOrDefault(),
                               Ngay_ket_thuc = a.Ngay_ket_thuc.GetValueOrDefault(),
                               Ten_loai = a.Ten_loai,
                               Ten_chuyen_gia = a.Ten_chuyen_gia
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
        public async Task<ResponseBase> Insert(RequestVeMoiHoiThao req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objVeMoiHoiThao.Insert(req);
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
        public async Task<ResponseBase> Update(RequestVeMoiHoiThao req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objVeMoiHoiThao.Update(req);
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
        public async Task<ResponseBase> Delete(int ID_ve_moi_hoi_thao)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objVeMoiHoiThao.Delete(ID_ve_moi_hoi_thao);
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