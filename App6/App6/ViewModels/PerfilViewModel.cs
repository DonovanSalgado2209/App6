using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PerfilViewModel : BaseViewModel
    {
        Command _regresar;

        public PerfilViewModel(INavigation navigation = null) : base (navigation)
        {
        }

  
  

        public Command Regresar 
        {
            get
            {
                if(_regresar == null)
                {
                    _regresar = new Command(GoToPaginaInicio);
                }
                return _regresar;
            }
        }

        private void GoToPaginaInicio()
        {
            Navigation.PushAsync(new PaginaInicio());
        }
    }
}
