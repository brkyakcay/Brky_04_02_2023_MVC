using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BrandViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Brand Name")]
        public string Name { get; set; }

        [Display(Name ="Product Count")]
        public int ProductCount { get; set; } 


    }
}