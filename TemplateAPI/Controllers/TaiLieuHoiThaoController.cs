using CommonClass.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
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
    [RoutePrefix("TaiLieuHoiThao")]
    [AllowAnonymous]
    public class TaiLieuHoiThaoController : ApiController
    {
        TaiLieuHoiThaoDAL objTaiLieu = new TaiLieuHoiThaoDAL();
        string urlFile = System.Web.Hosting.HostingEnvironment.MapPath("~/FileUpload");
        string url = WebConfigurationManager.AppSettings["Url_Dowload"];

        [HttpGet]
        [Route("Load_List")]
        public HttpResponseMessage Load_List(int ID_hoi_thao)
        {
            ReponseTaiLieuHoiThao res = new ReponseTaiLieuHoiThao();
            try
            {
                //Kiểm với nếu k tồn tại file (dữ liệu cũ) thì bỏ phần gán ID của file
                var list = (from a in objTaiLieu.Load_List().ToList().FindAll(x => x.ID_hoi_thao == ID_hoi_thao)
                            select new RequestTaiLieuHoiThao
                            {
                                ID_hoi_thao = a.ID_hoi_thao.GetValueOrDefault(),
                                ID_tai_lieu = a.ID_tai_lieu,
                                DocType = a.DocType,
                                FileName = a.FileName,
                                Mo_ta = a.Mo_ta,
                                Ten_tai_lieu = a.Ten_tai_lieu,
                                Url = File.Exists(urlFile + "\\" + a.FileName.Split('.')[0] + "_" + a.ID_tai_lieu + "." + a.FileName.Split('.')[1]) ? url + a.FileName.Split('.')[0] + "_" + a.ID_tai_lieu + "." + a.FileName.Split('.')[1] : url + a.FileName.Trim()
                            }).ToList();
                res.Data  = list;
                res.Status = StatusID.Success;
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = StatusID.InternalServer;
            }
            var stringdata = JsonConvert.SerializeObject(res);
            return new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };
        }

        [HttpGet]
        [Route("Delete")]
        public HttpResponseMessage Delete(int ID_tai_lieu)
        {

            ResponseBase res = new ResponseBase();
            try
            {
                var check = objTaiLieu.Delete(ID_tai_lieu).FirstOrDefault().Deleted;
                if (check > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Xoá thành công!";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Xoá thất bại!";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = StatusID.InternalServer;
            }
            var stringdata = JsonConvert.SerializeObject(res);
            return new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };
        }
        [HttpPost]
        [Route("Insert")]
        public HttpResponseMessage Insert(RequestTaiLieuHoiThao req)
        {

            ResponseBase res = new ResponseBase();
            try
            {
                if (req.FileName != null && req.fileBase64 != null)
                {
                    var check = objTaiLieu.Insert(req).FirstOrDefault().Identity;
                    if (check > 0)
                    {

                        var fileNameUpload = req.FileName.Split('.')[0] + "_" + check + "." + req.FileName.Split('.')[1];
                        var filedata = Convert.FromBase64String(req.fileBase64);
                        File.WriteAllBytes(urlFile + "\\" + fileNameUpload, filedata);
                        res.Status = StatusID.Success;
                        res.Message = "Thêm mới thành công!";
                    }
                    else
                    {
                        res.Status = StatusID.InternalServer;
                        res.Message = "Thêm mới thất bại!";
                    }
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Bạn chưa chọn tài liệu đính kèm";
                }

            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
                res.Status = StatusID.InternalServer;
            }
            var stringdata = JsonConvert.SerializeObject(res);
            return new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };
        }
    }
}