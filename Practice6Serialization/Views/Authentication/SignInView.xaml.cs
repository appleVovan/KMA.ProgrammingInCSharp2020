using System.Windows.Controls;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Navigation;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Views.Authentication
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
