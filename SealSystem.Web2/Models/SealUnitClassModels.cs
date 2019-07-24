using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SealSystem.Web2.Models
{
    public class SealUnitClassModels
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="分类名称")]
        public string Name { get; set; }

    }
}