using App6.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModel
{
    class PageThreeViewModel : BaseViewModel
    {
        Command _pageTwo;

        public PageThreeViewModel(INavigation navigation = null) : base(navigation)
        {
        }
        public Command GoToTwoCommand { get => _pageTwo ?? (_pageTwo = new Command(GoToTwo)); }

        private void GoToTwo()
        {
            Navigation.PushAsync(new PageTwo());
        }
    }
}
