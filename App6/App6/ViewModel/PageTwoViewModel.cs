using App6.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModel
{
    class PageTwoViewModel : BaseViewModel
    {
        Command _logOut;
        Command _goToDetails;

        public PageTwoViewModel(INavigation navigation = null) : base(navigation)
        {
        }

        public Command LogOutCommand { get => _logOut ?? (_logOut = new Command(() => Navigation.PopToRootAsync())); }
        public Command GoToDetailsCommand { get => _goToDetails ?? (_goToDetails = new Command(GoToDetailsAction)); }

        private void GoToDetailsAction()
        {
            Navigation.PushAsync(new DetailsPage());
        }
    }
}
