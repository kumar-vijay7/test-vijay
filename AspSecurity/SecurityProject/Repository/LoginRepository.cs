using Microsoft.Data.SqlClient;
using SecurityProject.Models;
using SecurityProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityProject.Repository
{
    public class LoginRepository : ILoginRepository
    {/// <summary>
     /// Authenticate the User Data with the database
     /// with the help of Entity framework
     /// </summary>
     /// <param name="user"></param>
     /// <returns>LoginModel</returns>
        public LoginModel Authenticate(UserRegistration user)
        {
            LoginModel login = null;
            var dbContext = new TestUserContext();
            try
            {
                using (dbContext)
                {

                    var userdata = dbContext.UserRegistration.Where(n => n.UserName == user.UserName).ToList();
                    var username = userdata.FirstOrDefault().UserName;
                    var password = userdata.FirstOrDefault().Password;
                    var role = userdata.FirstOrDefault().Role;
                    if (user.UserName == username && user.Password == password)
                    {
                        login = new LoginModel()
                        {
                            UserName = username,
                            Password = password,
                            Roles = role

                        };
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return login;
        }
        /// <summary>
        /// This method Getting the User Data from the Database
        /// </summary>
        /// <returns>userdata </returns>
        public List<UserRegistration> Getuserdata()
        {
            var dbContext = new TestUserContext();
            try
            {
                using (dbContext)
                {

                    var userdata = dbContext.UserRegistration.Select(n => n).ToList();
                    return userdata;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

