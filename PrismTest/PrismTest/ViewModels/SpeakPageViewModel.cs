using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTest.ViewModels
{
	public class SpeakPageViewModel : ViewModelBase
	{
        private string _textToSay = "Hello Prism";
        public string TextToSay
        {
            get { return _textToSay; }
            set { SetProperty(ref _textToSay, value); }
        }

        public DelegateCommand SpeakCommand { get; set; }

        public SpeakPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            SpeakCommand = new DelegateCommand(Speak);
        }

        private void Speak()
        {
            NavigationService.NavigateAsync("TabbedExamplePage");
        }
    }
}
