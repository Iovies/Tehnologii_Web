using SMCS.Models.Enums;
using SMCS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Models.DTOs
{
    public class TicketsDTO
    {
        public ILookup<DateTime, TicketDbModel> TicketsByDate { get; set; }
    }
}
