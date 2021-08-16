using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using TemplateAPI.CommonClass.Models.Utils;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class AccountDAL
    {
        private LinqDataContext db;
        public AccountDAL()
        {
            db = new LinqDataContext();
        }

        public ISingleResult<sp_UrcheckResult> Check_Member_Login(RequestLogin obj)
        {
            ISingleResult<sp_UrcheckResult> sp_result;
            try
            {
                sp_result = db.sp_Urcheck(obj.UserName, obj.Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        public ISingleResult<sp_htUsers_ChangePasswordResult> UserChangePassword(RequestChangePassword obj)
        {
            ISingleResult<sp_htUsers_ChangePasswordResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_ChangePassword(obj.UserName, obj.Password, obj.NewPassword);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
        public ISingleResult<sp_htUsers_LoginResult> User_Login(RequestLogin m)
        {
            ISingleResult<sp_htUsers_LoginResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Login(m.UserName, m.Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }
    }
}