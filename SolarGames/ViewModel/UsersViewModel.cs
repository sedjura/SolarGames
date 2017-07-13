using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SolarGames.Annotations;
using SolarGames.Model;

namespace SolarGames.ViewModel
{
    public class UsersViewModel : BaseViewModel
    {
        public ObservableCollection<UserViewModel> Users { get; set; }

        public UsersViewModel()
        {
            using (var context = new SolarGamesContext())
            {
                var contextUsers = context.Users.ToList();
                Users = new ObservableCollection<UserViewModel>(contextUsers.Select(user => new UserViewModel(user)));
            }
        }
    }
}