using Application.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            NavMenuItems = new NavMenuItemRepository(_context);

        }

        // UI
        public INavMenuItemRepository NavMenuItems { get; private set; }


        // DATA


      

        public void Dispose()
        {
            _context.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        public int UpdateDb()
        {            
            return _context.SaveChanges();
        }

        public Task<int> UpdateDbAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
