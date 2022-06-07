using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        // UI
        INavMenuItemRepository NavMenuItems { get; }
     

        int UpdateDb();

        Task<int> UpdateDbAsync();

    }
}
