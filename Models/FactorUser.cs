using Google.Authenticator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2FA.Models
{
    public class FactorUser
    {
        [Required]
        public string UserInputCode { get; set; }
        public SetupCode setupcode { get; set; }
        public bool AuthenSuccess { get; set; }
    }
}
