using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTest.ViewModels
{
	public class Tab1PageViewModel : ViewModelBase, IActiveAware
	{
        public DelegateCommand OnNextCommand { get; private set; }

        public Tab1PageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            OnNextCommand = new DelegateCommand(NextPage);
        }

        private void NextPage()
        {
            NavigationService.NavigateAsync("SpeakPage");
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set {
                SetProperty(ref _isActive, value);
            }
        }

        public event EventHandler IsActiveChanged;

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
