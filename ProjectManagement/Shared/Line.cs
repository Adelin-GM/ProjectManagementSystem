using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared
{
    public class Line
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ReportId { get; set; }
        public Report Report { get; set; }
    }
}
