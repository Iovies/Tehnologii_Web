using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Interfaces
{
    public interface IServicesManager
    {
        IArticlesService ArticlesService { get; }
        ITicketsService TicketsService { get; }
        IChatService ChatService { get; }
    }
}
