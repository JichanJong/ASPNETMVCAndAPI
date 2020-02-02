using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LoginModel
    {
        [DisplayName("用户名")]
        [Required(ErrorMessage = "请输入用户名")]
        public string UserName { get; set; }

        [DisplayName("密码")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "请输入密码")]
        public string  Password { get; set; }

    }
}