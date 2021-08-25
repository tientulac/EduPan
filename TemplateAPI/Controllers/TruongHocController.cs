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
    [RoutePrefix("TruongHoc")]
    [AllowAnonymous]
    public class TruongHocController : ApiController
    {
        TruongHocDAL objTruongHoc = new TruongHocDAL();
        TruongHocCongTrinhDAL objTHCT = new TruongHocCongTrinhDAL();
        TruongHocPhuongPhapDAL objTHPP = new TruongHocPhuongPhapDAL();
        private LinqDataContext db = new LinqDataContext();

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> Load_List()
        {
            ResponseTruongHoc res = new ResponseTruongHoc();
            try
            {
                var lst = (from a in objTruongHoc.Load_List()
                           select new RequestTruongHoc
                           {
                               ID_truong = a.ID_truong,
                               Ma_truong = a.Ma_truong,
                               Ten_truong = a.Ten_truong,
                               Dia_chi = a.Dia_chi
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
        public async Task<ResponseBase> Insert(RequestTruongHoc req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objTruongHoc.Insert(req);
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
        public async Task<ResponseBase> Update(RequestTruongHoc req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objTruongHoc.Update(req);
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
        public async Task<ResponseBase> Delete(int ID_truong)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objTruongHoc.Delete(ID_truong);
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

        [HttpGet]
        [Route("Load_CongTrinh")]
        public async Task<HttpResponseMessage> Load_CongTrinh(int ID_truong)
        {
            ResponseTruongHocCongTrinh res = new ResponseTruongHocCongTrinh();
            try
            {
                var lst = (from a in objTHCT.Load_List(ID_truong)
                           where a.Ten_chuyen_gia != null && a.Ten_chuyen_gia != ""
                           select new RequestTruongHocCongTrinh
                           {
                               ID_th_ct = a.ID_th_ct,
                               ID_cong_trinh = a.ID_cong_trinh.GetValueOrDefault(),
                               ID_truong = a.ID_truong.GetValueOrDefault(),
                               Ten_cong_trinh = a.Ten_cong_trinh,
                               Ngay_tao = a.Ngay_tao,
                               Trang_thai = a.Trang_thai.GetValueOrDefault(),
                               Ten_trang_thai = a.Trang_thai == 1 ? "Chờ duyệt" : "Đã duyệt",
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
        [Route("Insert_CongTrinh")]
        public async Task<ResponseBase> Insert_CongTrinh(RequestTruongHocCongTrinh req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                if (req.lst_ID_cong_trinh.Count > 0)
                {
                    var sp_delete = db.sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong(req.ID_truong);
                    if (sp_delete.FirstOrDefault().Deleted >= 0)
                    {
                        foreach (var item in req.lst_ID_cong_trinh)
                        {
                            var sp_result = objTHCT.Insert(item,req.ID_truong);
                            if (sp_result.FirstOrDefault().Identity > 0)
                            {
                                res.Status = StatusID.Success;
                                res.Message = "Cập nhật thành công !";
                            }
                            else
                            {
                                res.Status = StatusID.InternalServer;
                                res.Message = "Không thể lưu lúc này, vui lòng thử lại sau!";
                            }
                        }
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Không thể lưu lúc này, vui lòng thử lại sau!";
                    }
                }
                else
                {
                    var sp_delete = db.sp_eduTruongHoc_CongTrinhNC_Delete_ID_truong(req.ID_truong);
                    if (sp_delete.FirstOrDefault().Deleted > 0)
                    {
                        res.Status = StatusID.Success;
                        res.Message = "Cập nhật thành công !";
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Danh sách công trình để trống";
                    }
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
        [Route("Delete_CongTrinh")]
        public async Task<ResponseBase> Delete_CongTrinh(int ID_th_ct)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objTHCT.Delete(ID_th_ct);
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

        [HttpGet]
        [Route("Load_PhuongPhap")]
        public async Task<HttpResponseMessage> Load_PhuongPhap(int ID_truong)
        {
            ResponseTruongHocPhuongPhap res = new ResponseTruongHocPhuongPhap();
            try
            {
                var lst = (from a in objTHPP.Load_List(ID_truong)
                           where a.Ten_chuyen_gia != null && a.Ten_chuyen_gia != ""
                           select new RequestTruongHocPhuongPhap
                           {
                               ID_th_pp = a.ID_th_pp,
                               ID_phuong_phap = a.ID_phuong_phap.GetValueOrDefault(),
                               ID_truong = a.ID_truong.GetValueOrDefault(),
                               Ten_phuong_phap = a.Ten_phuong_phap,
                               Ngay_tao = a.Ngay_tao,
                               Trang_thai = a.Trang_thai.GetValueOrDefault(),
                               Ten_trang_thai = a.Trang_thai == 1 ? "Chờ duyệt" : "Đã duyệt",
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
        [Route("Insert_PhuongPhap")]
        public async Task<ResponseBase> Insert_PhuongPhap(RequestTruongHocPhuongPhap req)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                if (req.lst_ID_phuong_phap.Count > 0)
                {
                    var sp_delete = db.sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong(req.ID_truong);
                    if (sp_delete.FirstOrDefault().Deleted >= 0)
                    {
                        foreach (var item in req.lst_ID_phuong_phap)
                        {
                            var sp_result = objTHPP.Insert(item,req.ID_truong);
                            if (sp_result.FirstOrDefault().Identity > 0)
                            {
                                res.Status = StatusID.Success;
                                res.Message = "Cập nhật thành công !";
                            }
                            else
                            {
                                res.Status = StatusID.InternalServer;
                                res.Message = "Không thể lưu lúc này, vui lòng thử lại sau!";
                            }
                        }
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Không thể lưu lúc này, vui lòng thử lại sau!";
                    }
                }
                else
                {
                    var sp_delete = db.sp_eduTurongHoc_PhuongPhapNC_Delete_ID_truong(req.ID_truong);
                    if (sp_delete.FirstOrDefault().Deleted > 0)
                    {
                        res.Status = StatusID.Success;
                        res.Message = "Cập nhật thành công !";
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Danh sách công trình để trống";
                    }
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
        [Route("Delete_PhuongPhap")]
        public async Task<ResponseBase> Delete_PhuongPhap(int ID_th_pp)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objTHPP.Delete(ID_th_pp);
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