using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestWork.Models
{
    public class Worker
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        public int OfficeNum { get; set; }

        public string Role { get; set; }
        [Required]
        public int MobileNum { get; set; }
        [Required]
        public string Mail { get; set; }
        
        public string OfficeDesk { get; set; }


    }
}
