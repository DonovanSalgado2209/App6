using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        private Command _loginCommand;
        private bool isErrrorLogin;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {

        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public Command LoginCommand
        {
            get => _loginCommand ?? (_loginCommand = new Command(GoToLoginAction));
        }
        public bool IsErrrorLogin
        {
            get => isErrrorLogin;
            set
            {
                isErrrorLogin = value;
                OnPropertyChanged();
            }
        }

        private void GoToLoginAction()
        {
            IsErrrorLogin = !(string.Equals(UserName, "donovan") && string.Equals(Password, "dono"));
            if (!isErrrorLogin)
            {
                UserName = String.Empty;
                Password = String.Empty;
                Navigation.PushAsync(new PaginaInicio());
            }
        }
    }
}
 