using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PaginaInicioViewModel : BaseViewModel
    {
        Command _goToHome;
        Command _goToPerfil;
        public PaginaInicioViewModel(INavigation navigation = null) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public Command GoToHome 
        { 
            get
            {
              if(_goToHome == null)
                {
                    _goToHome = new Command(GoToHomeAction);
                }
                return _goToHome;
            }
        }

        public Command GoToPerfil 
        {
            get
            {
                if(_goToPerfil == null)
                {
                    _goToPerfil = new Command(GoToPerfilAction);
                }
                return _goToPerfil;
            }
        }

        private void GoToPerfilAction()
        {
            Navigation.PushAsync(new Perfil());
        }

        private void GoToHomeAction()
        {
            Navigation.PopToRootAsync();
        }
    }
}
