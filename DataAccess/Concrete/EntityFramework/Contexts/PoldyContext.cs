using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class PoldyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-M6AH6CF;initial catalog=poldy;integrated security=true");
        }
        public DbSet<Per> Pers { get; set; }
    }
}
