using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }
        ITicketRepository Tickets { get; }
        IDormRepository Dorms { get; }
        IFloorRepository Floors { get; }
        IRoomRepository Rooms { get;}
        IUsersRepository Users { get; }
        IContentTrackerRepository ContentTrackers { get; }
        int Complete();
    }
}
