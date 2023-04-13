using SMCS.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.DTOs
{
    public class TicketDTO
    {
        public Guid ID { get; set; }
        public string TicketNumber { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDescription { get; set; }
        public DateTime Created { get; set; }
        public DateTime Closed { get; set; }
        public TicketStatusEnum TicketStatus { get; set; }
    }
}
