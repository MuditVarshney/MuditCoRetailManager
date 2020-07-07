using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace MRMDesktopUserInterface.ViewModels
{
   public  class ShellViewModel:Conductor<Object>
    {
        private LoginViewModel _LoginVM;
        public ShellViewModel(LoginViewModel LoginVM)
        {
            _LoginVM = LoginVM;
            ActivateItem(_LoginVM); //Using Calliburn Micro

        }
    }
}
