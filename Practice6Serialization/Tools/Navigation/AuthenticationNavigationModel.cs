using System;
using KMA.ProgrammingInCSharp2020.Practice6Serialization.Views.Authentication;
using MainView = KMA.ProgrammingInCSharp2020.Practice6Serialization.Views.MainView;
using SignUpView = KMA.ProgrammingInCSharp2020.Practice6Serialization.Views.Authentication.SignUpView;

namespace KMA.ProgrammingInCSharp2020.Practice6Serialization.Tools.Navigation
{
    internal class AuthenticationNavigationModel : BaseNavigationModel
    {
        public AuthenticationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {
            
        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.SignIn:
                    AddView(ViewType.SignIn, new SignInView());
                    break;
                case ViewType.SignUp:
                    AddView(ViewType.SignUp, new SignUpView());
                    break;
                case ViewType.Main:
                    AddView(ViewType.Main, new MainView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
