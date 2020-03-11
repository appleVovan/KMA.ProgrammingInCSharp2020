using System;
using System.Windows;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Models;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.DataStorage;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Managers
{
    internal static class StationManager
    {
        private static IDataStorage _dataStorage;

        internal static User CurrentUser { get; set; }

        internal static IDataStorage DataStorage
        {
            get { return _dataStorage; }
        }

        internal static void Initialize(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }
        
        internal static void CloseApp()
        {
            MessageBox.Show("ShutDown");
            Environment.Exit(1);
        }
    }
}
