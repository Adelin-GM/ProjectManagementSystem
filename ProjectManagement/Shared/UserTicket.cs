using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Shared
{
    public class UserTicket
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string TicketName { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime FinishedDate { get; set; }

        public Ticket Ticket { get; set; }
    }
}
