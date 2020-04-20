using BlazorAssignment.Library.Models.entityModels;
using BlazorAssignment.WebApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.WebApi.Services
{
    public class LoginServices : ILoginRepository
    {
          StudentDBContext _studentDBContext;
        public LoginServices()
        {
            _studentDBContext =new StudentDBContext();
        }
        public async Task<bool> Login(TblLogin user)
        {
           
                var response =await _studentDBContext.TblLogin.FirstOrDefaultAsync(u => u.UserName == user.UserName);
                if(response.UserName==user.UserName && response.Password==user.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
    }
}
