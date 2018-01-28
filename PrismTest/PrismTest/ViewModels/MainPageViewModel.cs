using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismTest.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateToSpeakPageCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
        }

        private void NavigateToSpeakPage()
        {
            NavigationService.NavigateAsync("SpeakPage");
        }
    }
}
