using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared
{
    public class UserProject
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string ProjectName { get; set; }
        public Project Project { get; set; }
    }
}
