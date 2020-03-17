using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SecurityProject.Models;
using SecurityProject.Models.Models;
using SecurityProject.Repository;
using SecurityProject.Settings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProject.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginrepository;
        private IConfiguration _config;
        private JwtSettings _jwt;
        public LoginService(ILoginRepository loginrepository, IConfiguration config, IOptions<JwtSettings> jwt)
        {
            _loginrepository = loginrepository; 
            _config = config;
            _jwt = jwt.Value;
        }
        /// <summary>
        /// this method Authenticate the User is valid aur not
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Userlogin model data</returns>
        public LoginModel Authenticate(UserRegistration user)
        {
            var result=_loginrepository.Authenticate(user);
            return result;            
        }

        public List<UserRegistration> Getuserdata()
        {
            var result = _loginrepository.Getuserdata();
            return result;
        }
        /// <summary>
        /// this method genrating the token 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>token</returns>
        public string TokenCreator(LoginModel user)
        {
            try
            {
                //Header
                var Key = Encoding.ASCII.GetBytes(_jwt.Key);
                var credentials = new SigningCredentials(new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256);
                //payload
                var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim("Password",user.Password),
                new Claim(ClaimTypes.Role,user.Roles)
            };
                //signature
                var token = new JwtSecurityToken(_jwt.Issuer, _jwt.Issuer, claims,
                  expires: DateTime.Now.AddMinutes(1),
                  signingCredentials: credentials);

                return new JwtSecurityTokenHandler().WriteToken(token);

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
