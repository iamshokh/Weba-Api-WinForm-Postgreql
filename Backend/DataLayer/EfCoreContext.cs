using Backend.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.DataLayer
{
    public class EfCoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;UserName=postgres;Database=postgres;Password=shaxzod71319#");

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
