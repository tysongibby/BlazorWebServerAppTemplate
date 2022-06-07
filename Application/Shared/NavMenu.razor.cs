using Application.Data.DataModels.Ui;
using System.Collections.Generic;

namespace Application.Shared
{
    public partial class NavMenu
    {
        //[Inject]
        //IUnitOfWork UnitOfWork { get; set; }

        public List<NavMenuItem> NavMenuItems { get; set; } = new List<NavMenuItem>();

        string NavMenuOffCanvasClassString => collapseNavMenu ? "offcanvas offcanvas-end" : null;
        bool collapseNavMenu = true;

        protected override void OnInitialized()
        {
            //NavMenuItems = UnitOfWork.NavMenuItems.GetAll().ToList();
        }

        void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        void CollapseNavMenu()
        {
            collapseNavMenu = true;
        }
    }
}
