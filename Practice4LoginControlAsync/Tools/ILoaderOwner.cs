using System.ComponentModel;
using System.Windows;

namespace KMA.ProgrammingInCSharp2020.Practice4LoginControlAsync.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
