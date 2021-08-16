using CommonClass.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using TemplateAPI.Common;
using TemplateAPI.CommonClass.Models;
using TemplateAPI.CommonClass.Models.Utils;
using TemplateAPI.DAL;
using TemplateAPI.Models;
using ThienAn.UniLibrary;

namespace TemplateAPI.Controllers
{
    [RoutePrefix("Account")]
    public class AccountAPIController : ApiController
    {
        private LinqDataContext db;
        public AccountAPIController() // Khởi tạo kết nối SQL
        {
            db = new LinqDataContext();
        }

        AccountDAL objAccount = new AccountDAL();

        /**
         * LOGIN ACCOUNT
         * Username
         * Password
         */
        [AllowAnonymous]
        [HttpPost]
        [Route("AutoLogin")]
        public HttpResponseMessage AutoLogin([FromBody] RequestLogin m)
        {
            ResponseLogin res = new ResponseLogin();
            bool EnableRoles = Convert.ToBoolean(WebConfigurationManager.AppSettings["EnableRoles"]);
            try
            {

                var MemberLogin = objAccount.Check_Member_Login(m).ToList();
                if (MemberLogin.Count() != 1)
                {
                    res.Status = StatusID.AccessDenied;
                    res.Message = "Thông tin đăng nhập không chính xác";
                }
                else
                {
                    var User = MemberLogin.FirstOrDefault();
                    res.Info = new UserInfo();
                    UserInfo us = new UserInfo();
                    us.FullName = User.FullName;
                    us.Email = User.Email;
                    us.UserName = m.UserName;
                    res.Token = Utils.Encrypt(User.UserID.ToString());
                    res.Info = us;
                    res.Status = StatusID.Success;
                    res.Message = "Đăng nhập thành công";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            var stringdata = JsonConvert.SerializeObject(res);
            return new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };
        }


        //------------------------------------------------CHANGE Password-------------------------------------------
        [AllowAnonymous]
        [HttpPost]
        [Route("ChangePassword")]
        public HttpResponseMessage ChangePassword([FromBody] RequestChangePassword m)
        {
            ResponseBase res = new ResponseBase();
            try
            {
                m.Password = XCrypto.MD5(m.Password);
                m.NewPassword = XCrypto.MD5(m.NewPassword);
                var sp_result = objAccount.UserChangePassword(m);
                if (sp_result.FirstOrDefault().ROW == 1)
                {
                    res.Status = StatusID.Success;
                    res.Message = "Mật khẩu đã được thay đổi";
                }
                else
                {
                    res.Status = StatusID.AccessDenied;
                    res.Message = "Thông tin không chính xác";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            var stringdata = JsonConvert.SerializeObject(res);
            return new HttpResponseMessage()
            {
                Content = new StringContent(stringdata, Encoding.UTF8, "application/json")
            };
        }

        /**
         * LOGIN ACCOUNT
         * Username
         * Password
         */
        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public ResponseLogin Login([FromBody] RequestLogin m)
        {
            ResponseLogin res = new ResponseLogin();
            bool EnableRoles = Convert.ToBoolean(WebConfigurationManager.AppSettings["EnableRoles"]);

            try
            {
                m.Password = XCrypto.MD5(m.Password);
                var MemberLogin = objAccount.User_Login(m).ToList();
                if (MemberLogin.Count() != 1)
                {
                    res.Status = StatusID.AccessDenied;
                    res.Message = "Thông tin đăng nhập không chính xác";
                }
                else
                {
                    var User = MemberLogin.FirstOrDefault();
                    res.Info = new UserInfo();
                    UserInfo us = new UserInfo();
                    us.UserID = User.UserID;
                    us.FullName = User.FullName;
                    us.Email = User.Email;
                    us.UserName = m.UserName;

                   
                    res.Token = API.createToken(m.UserName);
                    res.Info = us;
                    res.Status = StatusID.Success;
                    res.Message = "Đăng nhập thành công";
                }
            }
            catch (Exception ex)
            {
                res.Status = StatusID.InternalServer;
                res.Message = ex.Message;
            }
            return res;
        }      
    }
}