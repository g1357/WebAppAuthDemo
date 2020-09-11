using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAuthDemo.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage ="Have to supply aa username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Have to supply aa password")]
        public string Password { get; set; }
    }
}
