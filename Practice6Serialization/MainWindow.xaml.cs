using System.Windows;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.ViewModels;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
