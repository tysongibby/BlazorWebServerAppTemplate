using GenericRepositoryForEfCore;
using Application.Data.DataModels.Ui;
using Application.Data.Repositories.Interfaces;

namespace Application.Data.Repositories
{
    public class NavMenuItemRepository : GenericRepository<NavMenuItem>,  INavMenuItemRepository
    {
        public NavMenuItemRepository(ApplicationDbContext context) : base(context)
        {            
        }

        public ApplicationDbContext Context 
        {
            get
            {
                return Context as ApplicationDbContext;
            }
        }
    }
}
