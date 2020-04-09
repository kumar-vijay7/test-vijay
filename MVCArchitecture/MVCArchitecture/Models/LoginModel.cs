using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCArchitecture.Models
{
    public class LoginModel
    {
        [Required]
        public string username { get; set; }
       
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}