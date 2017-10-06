using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvcdemo.Models
{
    public class Profile
    {
        public int ID { get; set; }
        [Required]
        public string EmployeeNo { get; set; }
        public string Position { get; set; }
        public string Remarks { get; set; }
    }
}
