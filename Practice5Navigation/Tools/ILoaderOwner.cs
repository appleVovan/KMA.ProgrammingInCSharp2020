using System.ComponentModel;
using System.Windows;

namespace KMA.ProgrammingInCSharp2020.Practice5Navigation.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
