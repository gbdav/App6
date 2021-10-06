using App6.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModel
{
    class MainPageViewModel : BaseViewModel
    {
        private string _usuario;
        private string _contrasena;
        private Command _loginCommand;
        private bool isErrorLogin;
        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public string Usuario
        {
            get => _usuario;
            set
            {
                _usuario = value;
                OnPropertyChanged();
            }
        }
        public string Contrasena
        {
            get => _contrasena;
            set
            {
                _contrasena = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand
        {
            get => _loginCommand ?? (_loginCommand = new Command(GoToLoginAction));
        }
        public bool IsErrorLogin
        {
            get => isErrorLogin;
            set
            {
                isErrorLogin = value;
                OnPropertyChanged();
            }
        }
        private void GoToLoginAction()
        {
            IsErrorLogin = !(Usuario == "David" && Contrasena == "123456");
            if (!IsErrorLogin)
            {
                Usuario = String.Empty;
                Contrasena = String.Empty;
                Navigation.PushAsync(new PageTwo());
            }
        }
    }
}
