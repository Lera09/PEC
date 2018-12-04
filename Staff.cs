using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PECAssetWeb.Models
{
    public class Staff: Person
    {
        
        [Display(Name="Date Hired")]
        [DataType(DataType.Date)]
        public DateTime HiredDate { get; set; }
        public string Office { get; set; }

    }
}