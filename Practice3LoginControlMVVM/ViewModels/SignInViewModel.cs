using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using KMA.ProgrammingInCSharp2020.Practice3LoginControlMVVM.Models;
using KMA.ProgrammingInCSharp2020.Practice3LoginControlMVVM.Tools.MVVM;

namespace KMA.ProgrammingInCSharp2020.Practice3LoginControlMVVM.ViewModels
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        #region Fields

        private User _user = new User();
        private RelayCommand<object> _signInCommand;
        private RelayCommand<object> _signUpCommand;
        private RelayCommand<object> _cancelCommand;
        #endregion

        #region Properties
        public string Login
        {
            get
            {
                return _user.Login;
            }
            set
            {
                _user.Login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return _user.Password;
            }
            set
            {
                _user.Password = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> SignInCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand<object>(o =>
                           {
                               MessageBox
                                   .Show
                                       ($"Login successful for user {Login}");
                           }, CanExecuteCommand
                       ));
            }
        }

        public RelayCommand<object> SignUpCommand
        {
            get
            {
                return _signUpCommand ?? (_signUpCommand = new RelayCommand<object>(o =>
                           {
                               MessageBox
                                   .Show
                                       ($"Registration successful for user {Login}");
                           }, CanExecuteCommand
                       ));
            }
        }
        #endregion

        public bool CanExecuteCommand(object o)
        {
            return !(string.IsNullOrWhiteSpace(Login)
                     || string.IsNullOrWhiteSpace(Password));
        }

        #region INotifyPropertyImplementation
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
