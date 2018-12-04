using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PECAssetWeb.Models
{
    public class Student:Person
    {
        [Required]
        [Display(Name ="Qualification Name")]
        public string Qual { get; set; }
        
       
        
    }
}
