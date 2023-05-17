using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.BusinessLogic.Interfaces
{
    public interface IServicesManager : IDisposable
    {
        IUserService UserService { get; }
        IArticlesService ArticlesService { get; }
        ITicketsService TicketsService { get; }
        IChatService ChatService { get; }
    }
}
