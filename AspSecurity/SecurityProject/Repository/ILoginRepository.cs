using SecurityProject.Models;
using SecurityProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityProject.Repository
{
   public interface ILoginRepository
    {
        public LoginModel Authenticate(UserRegistration user);
        public List<UserRegistration> Getuserdata();
    }
}
