using System.Windows.Controls;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.ViewModels;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Views
{
    public partial class MainView : UserControl, INavigatable
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); 
        }
    }
}
