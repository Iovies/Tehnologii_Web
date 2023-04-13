using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Domains.Entities
{
    public  class Ticket
    {
        public string TicketNumber { get; set; }
        public string TicketTitle { get; set; }
        public string TicketDescription { get; set; }
        public DateTime Created { get; set; }
        public DateTime Closed { get; set; }
    }
}
