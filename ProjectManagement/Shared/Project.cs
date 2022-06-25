using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public Company Company { get; set; }
    }
}
