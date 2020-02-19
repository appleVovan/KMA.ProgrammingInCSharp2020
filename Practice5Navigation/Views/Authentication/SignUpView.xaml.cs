using System.Windows.Controls;
using KMA.ProgrammingInCSharp2020.Practice5Navigation.Tools.Navigation;
using KMA.ProgrammingInCSharp2020.Practice5Navigation.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2020.Practice5Navigation.Views.Authentication
{
    public partial class SignUpView : UserControl, INavigatable
    {
        internal SignUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel();
        }
    }
}
