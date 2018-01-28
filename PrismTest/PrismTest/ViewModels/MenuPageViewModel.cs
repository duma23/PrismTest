using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrismTest.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public DelegateCommand PageOne { get; private set; }
        public DelegateCommand PageTwo { get; private set; }

        public MenuPageViewModel(INavigationService navigationService)
            :base (navigationService)
        {
            PageOne = new DelegateCommand(GoToPageOne);
            PageTwo = new DelegateCommand(GoToPageTwo);
            
        }

        private void GoToPageTwo()
        {
            NavigationService.NavigateAsync("SpeakPage");
        }

        private void GoToPageOne()
        {
            NavigationService.NavigateAsync("NavigationPage/SpeakPage");
        }
    }
}
