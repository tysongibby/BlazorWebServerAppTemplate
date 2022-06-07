using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Application.Data.DataModels.Ui;
using System.Collections.Generic;

namespace Application.Data.EntityConfigurations
{
    public class NavMenuItemConfig : IEntityTypeConfiguration<NavMenuItem>
    {
        public void Configure(EntityTypeBuilder<NavMenuItem> builder)
        {
            List<NavMenuItem> NavMenuItems = new List<NavMenuItem>
            {
                new NavMenuItem {Id = 1, Name = "Events", Link = "#" },
                new NavMenuItem {Id = 2, Name = "Calendar", Link = "/calendar"},                
                new NavMenuItem {Id = 4, Name = "About", Link = "/about"},
                new NavMenuItem {Id = 5, Name = "Donate", Link = "#"}
            };

            builder.HasData(NavMenuItems);
        }
    }
}
