using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using TemplateAPI.CommonClass.Models.InputModels;
using TemplateAPI.Controllers;
using TemplateAPI.Models;

namespace TemplateAPI.DAL
{
    public class UserDAL
    {
        private LinqDataContext db;
        public UserDAL()
        {
            db = new LinqDataContext();
        }   

        //-------------------------------- GET ALL Users--------------------------------------------

        public ISingleResult<sp_htUsers_Load_List_AllResult> Users_Load_List_All()
        {
            ISingleResult<sp_htUsers_Load_List_AllResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Load_List_All();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }


        //-------------------------------- INSERT User--------------------------------------------

        public ISingleResult<sp_htUsers_InsertResult> User_Insert(RequestUser m)
        {
            ISingleResult<sp_htUsers_InsertResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Insert(m.UserName, m.Password, m.FullName, m.Admin, m.Active, m.Email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- UPDATE User--------------------------------------------

        public ISingleResult<sp_htUsers_UpdateResult> User_Update(RequestUser m)
        {
            ISingleResult<sp_htUsers_UpdateResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Update(
                    m.UserID,
                    m.FullName,
                    m.Admin,
                    m.Active,
                    m.Email
                );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //-------------------------------- DELETE User--------------------------------------------

        public ISingleResult<sp_htUsers_DeleteResult> User_Delete(int ID_user)
        {
            ISingleResult<sp_htUsers_DeleteResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_Delete(ID_user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

        //--------------------------------UPDATE Info--------------------------------------------

        public ISingleResult<sp_htUsers_UpdateInfoResult> UpdateInfo(RequestUser req)
        {
            ISingleResult<sp_htUsers_UpdateInfoResult> sp_result;
            try
            {
                sp_result = db.sp_htUsers_UpdateInfo(req.UserID, req.FullName, req.Email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sp_result;
        }

    }
}