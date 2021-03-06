﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Models;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Managers;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.DataStorage
{
    internal class SerializedDataStorage:IDataStorage
    {
        private readonly List<User> _users;

        internal SerializedDataStorage()
        {
            try
            {
                _users = SerializationManager.Deserialize<List<User>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _users = new List<User>();
            }
        }

        public bool UserExists(string login)
        {
            return _users.Exists(u => u.Login == login);
        }

        public User GetUserByLogin(string login)
        {
            return _users.FirstOrDefault(u => u.Login == login);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            SaveChanges();
        }

        public List<User> UsersList
        {
            get { return _users.ToList(); }
        }

        private void SaveChanges()
        {
            SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        }
    }
}

