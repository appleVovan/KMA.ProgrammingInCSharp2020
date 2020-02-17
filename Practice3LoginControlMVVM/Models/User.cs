using System;

namespace KMA.ProgrammingInCSharp2020.Practice3LoginControlMVVM.Models
{
    class User
    {
        private String _login;
        private String _password;

        #region Properties
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        #endregion


    }
}
