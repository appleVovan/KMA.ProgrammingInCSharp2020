using System.Windows.Controls;
using KMA.ProgrammingInCSharp2020.Practice5Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2020.Practice5Navigation.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2020.Practice5Navigation.Views.Authentication
{
    public partial class SignInView : UserControl,INavigatable
    {
        internal SignInView()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
