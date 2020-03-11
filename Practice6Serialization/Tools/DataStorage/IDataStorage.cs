using System.Collections.Generic;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Models;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.DataStorage
{
    internal interface IDataStorage
    {
        bool UserExists(string login);

        User GetUserByLogin(string login);

        void AddUser(User user);

        List<User> UsersList { get; }
    }
}
