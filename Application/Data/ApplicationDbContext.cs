using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Data.DataModels.Ui;
using Application.Data.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Application
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public IConfiguration Configuration { get; }

        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(IConfiguration configuration, DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Configuration = configuration;            
        }

        // UI
        public virtual DbSet<NavMenuItem> NavMenuItems { get; set; }


        // DATA


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // builds models from IdentityDbContext since OnModelCreating has been overridden

            // UI
            modelBuilder.ApplyConfiguration<NavMenuItem>(new NavMenuItemConfig());

            // DATA


        }
    }
}
