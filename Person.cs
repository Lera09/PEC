using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PECAssetWeb.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        
        public DateTime? DOB { get; set; }
        
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        
        public string Phone { get; set; }
        
        [Display(Name = "Identity Number")]
        public int IDNumber { get; set; }

    }
}
