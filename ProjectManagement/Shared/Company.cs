using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public List<Project> Projects { get; set; }
    }
}
