﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTest.ViewModels
{
	public class MasterDetailTestPageViewModel : ViewModelBase
	{
        

        public MasterDetailTestPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            
        }

        
    }
}
