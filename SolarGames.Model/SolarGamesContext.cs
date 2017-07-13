using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarGames.Model.Model;

namespace SolarGames.Model
{
    public class SolarGamesContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public SolarGamesContext() : base(@"Data Source=DIR-VELIGORSKIY\MSSQLSERVER14;Initial Catalog=SolarGames;User ID=sa;Password=1;")
        {
            
        }
    }
}
