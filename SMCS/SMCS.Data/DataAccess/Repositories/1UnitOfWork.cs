using DataAccess.Repositories;
using SMCS.Data.DataAccess.Interfaces;
using SMCS.Data.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCS.Data.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Articles = new ArticleRepository(_context);
            Tickets = new TicketRepository(_context);
            Dorms = new DormRepository(_context);
            Floors = new FloorRepository(_context);
            Rooms = new RoomRepository(_context);
            Users = new UsersRepository(_context);
        }

        public IArticleRepository Articles { get; private set; }

        public ITicketRepository Tickets { get; private set; }

        public IDormRepository Dorms { get; private set; }

        public IFloorRepository Floors { get; private set; }

        public IRoomRepository Rooms { get; private set; }

        public IUsersRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
