using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTest.ViewModels
{
	public class LoginPageViewModel : ViewModelBase
	{
        public DelegateCommand LoginCommand { get; private set; }

        public LoginPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            LoginCommand = new DelegateCommand(Login);
        }

        private void Login()
        {
            NavigationService.NavigateAsync("/MasterDetailTestPage/NavigationPage/MainPage");
        }
    }
}
