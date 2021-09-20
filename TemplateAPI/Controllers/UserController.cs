using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using TemplateAPI.CommonClass.Models;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.CommonClass.Models.OutputModels;
using TemplateAPI.DAL;
using TemplateAPI.Models;

namespace TemplateAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("UserManager")]
    public class UserManagerAPIController : ApiController
    {
        UserDAL objUser = new UserDAL();
        private LinqDataContext db = new LinqDataContext();
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] frData = Encoding.UTF8.GetBytes(str);
            byte[] tgData = md5.ComputeHash(frData);
            string hashString = "";
            for (int i = 0; i < tgData.Length; i++)
            {
                hashString += tgData[i].ToString("x2");
            }
            return hashString;
        }

        //-------------------------------- GET ALL Users--------------------------------------------

        [HttpGet]
        [Route("Load_List")]
        public async Task<HttpResponseMessage> GetUserList()
        {
            ResponseUser res = new ResponseUser();
            try
            {
                var lst = (from a in objUser.Users_Load_List_All()
                           orderby a.UserID descending
                           select new RequestUser
                           {
                               UserID = a.UserID,
                               UserName = a.UserName,
                               Password = a.PassWord,
                               FullName = a.FullName,
                               Email = a.Email,
                               Admin = a.Admin,
                               Active = a.Active,
                               Trang_thai = a.Active == true ? "Còn hiệu lực" : "Vô hiệu hóa"
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

        //-------------------------------- INSERT User--------------------------------------------
        [HttpPost]
        [Route("Insert")]
        public async Task<ResponseBase> Insert_User(RequestUser m)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                m.Active = m.Active == null ? false : true;
                m.Admin = m.Admin == null ? false : true;
                m.Password = GetMD5(m.Password);
                var rs = objUser.User_Insert(m).ToList();
                if (rs.FirstOrDefault().Identity > 0)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Đã thêm mới User";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Thêm thất bại";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        
        //-------------------------------- UPDATE User--------------------------------------------
        [HttpPost]
        [Route("Update")]
        public async Task<ResponseBase> Update_User(RequestUser m)
        {
            ResponseUser res = new ResponseUser();
            try
            {
                var rs = objUser.User_Update(m);
                if (rs.FirstOrDefault().Updated == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Tài khoản người dùng đã được cập nhật";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể lưu tài khoản người dùng lúc này, vui lòng thử lại sau!";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

        //-------------------------------- DELETE User--------------------------------------------
        [HttpGet]
        [Route("Delete")]
        public async Task<ResponseBase> Delete_User(int ID_user)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                var rs = objUser.User_Delete(ID_user);
                if (rs.FirstOrDefault().Deleted == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Tài khoản người dùng đã được xóa!";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể xóa tài khoản người dùng lúc này, vui lòng thử lại sau!";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return await Task.FromResult(res);
        }

       

        //-------------------------------- UPDATE Info--------------------------------------------
        [HttpPost]
        [Route("UpdateInfo")]
        public async Task<ResponseBase> UpdateInfo(RequestUser req)
        {
            ResponseUser res = new ResponseUser();
            try
            {
                var rs = objUser.UpdateInfo(req);
                if (rs.FirstOrDefault().Updated == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Tài khoản người dùng đã được cập nhật";
                }
                else
                {
                    res.Status = StatusID.InternalServer;
                    res.Message = "Không thể lưu tài khoản người dùng lúc này, vui lòng thử lại sau!";
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