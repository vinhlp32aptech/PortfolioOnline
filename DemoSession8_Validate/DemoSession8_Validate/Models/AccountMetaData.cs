using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSession8_Validate.Models
{

    public class AccountMetaData
    {
        [MinLength(3)]
        [MaxLength(10)]
        [Required]
        public string Username { get; set; }

        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [Range(18,60)]
        public int Age { get; set; }
    }

    [ModelMetadataType(typeof(AccountMetaData))]
    public partial class Account
    {

    }

}
