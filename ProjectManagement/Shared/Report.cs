using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ReportDate { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Line[] reportLines;
    }
}
