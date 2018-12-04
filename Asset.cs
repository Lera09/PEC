using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PECAssetWeb.Models
{
    public class Asset
    {
        [Key]
        public int AssetID { get; set; }
        [Required]
        [Display(Name ="Item Type")]
        public string Item { get; set; }

        public string Location { get; set; }

        public List<Person> Person { get; set; }
        [Display(Name ="Serial Number")]
        public string Serial { get; set; }
        [Required]
        [Display(Name ="Bar Code")]
        public string Barcode { get; set; }
    }
}
