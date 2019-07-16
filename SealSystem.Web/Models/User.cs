using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SealSystem.Web.Models
{
    public class User
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Pwd { get; set; }
    }
}