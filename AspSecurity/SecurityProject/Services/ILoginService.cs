using SecurityProject.Models;
using SecurityProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityProject.Services
{
   public interface ILoginService
    {
        public LoginModel Authenticate(UserRegistration user);
        public string TokenCreator(LoginModel user);

        public List<UserRegistration> Getuserdata();
    }
}
