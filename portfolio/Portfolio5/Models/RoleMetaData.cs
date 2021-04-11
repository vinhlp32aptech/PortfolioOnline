using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Models
{
    public class RoleMetaData
    {

        [Required]
        public string NameRole { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string Datecreated { get; set; }

        [Required]
        public string Dateupdated { get; set; }

    }

    [ModelMetadataType(typeof(RoleMetaData))]
    public partial class Account
    {

    }
}
