using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarGames.Model.Model;

namespace SolarGames.Model
{
   public  class SolarGamesInitializer : DropCreateDatabaseIfModelChanges<SolarGamesContext>
   {
       private Type _hack = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        protected override void Seed(SolarGamesContext context)
        {
            var users =new List<User>()
            {
                new User() {Name = "Аркадьев Аркадий Аркадьевич"},
                new User() {Name = "Борисов Борис Борисович"}
            };
            users.ForEach(user => context.Users.Add(user));
            context.SaveChanges();
            var roles = new List<Role>()
            {
                new Role() {Name = "Администратор"},
                new Role() {Name = "Игрок"}
            };
            roles.ForEach(role => context.Roles.Add(role));
            context.SaveChanges();
            var userRoles = new List<UserRole>()
            {
                new UserRole() {UserId = 1, RoleId = 1},
                new UserRole() {UserId = 2, RoleId = 1},
                new UserRole() {UserId = 1, RoleId = 2},
            };
            userRoles.ForEach(userRole => context.UserRoles.Add(userRole));
            context.SaveChanges();
        }
    }
}
