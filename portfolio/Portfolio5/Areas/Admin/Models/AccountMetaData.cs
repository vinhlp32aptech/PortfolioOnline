using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Models
{
    public class AccountMetaData
    {

        [MinLength(5)]
        [MaxLength(20)]
        [Required]
        public string Username { get; set; }

        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        
    }

    [ModelMetadataType(typeof(AccountMetaData))]
    public partial class Account { }

}
