using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaiThi_NhatCuong.Models
{
    public class AccountMetaData
    {
        [MinLength(3)]
        [MaxLength(10)]
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string PassWord { get; set; }

    }
    [ModelMetadataType(typeof(AccountMetaData))]
    public partial class Account
    {

    }
}

