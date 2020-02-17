using System.Windows.Controls;
using KMA.ProgrammingInCSharp2020.Practice3LoginControlMVVM.ViewModels;

namespace KMA.ProgrammingInCSharp2020.Practice3LoginControlMVVM.Views.Authentication
{
    /// <summary>
    /// Interaction logic for SignInView.xaml
    /// </summary>
    public partial class SignInView : UserControl
    {
        private SignInViewModel _viewModel;
        public SignInView()
        {
            InitializeComponent();
            DataContext = _viewModel = new SignInViewModel();
        }
    }

}
