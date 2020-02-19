using System.Windows.Controls;
using KMA.ProgrammingInCSharp2020.Practice4LoginControlAsync.ViewModels.Authentication;

namespace KMA.ProgrammingInCSharp2020.Practice4LoginControlAsync.Views.Authentication
{
    public partial class SignInView : UserControl
    {
        internal SignInView()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
