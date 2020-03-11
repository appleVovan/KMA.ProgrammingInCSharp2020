using System.Collections.ObjectModel;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Models;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Managers;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get => _users;
            private set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public string CurrentUser
        {
            get
            {
                return $"Current User {StationManager.CurrentUser}";
            }
        }

        public MainViewModel()
        {
            _users = new ObservableCollection<User>(StationManager.DataStorage.UsersList);
        }
        
    }
}
