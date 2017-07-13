using System.ComponentModel;
using System.Runtime.CompilerServices;
using SolarGames.Annotations;
using SolarGames.Model.Model;

namespace SolarGames.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public UserViewModel(User user)
        {
            Name = user.Name;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}