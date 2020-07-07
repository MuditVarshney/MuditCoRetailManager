﻿using Caliburn.Micro;
using MRMDesktopUserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRMDesktopUserInterface.ViewModels
{
    
   public class LoginViewModel : Screen
    {
        private String _username;
        private String _password;
        private IAPIHelper _apihelper;

        public LoginViewModel(IAPIHelper apihelper)
        {
            _apihelper = apihelper;
        }
        public String UserName
        {
            get { return _username; }
            set {
                _username = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }
           

        public String Password
        {
            get { return _password; }
            set {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
         get
            {
                bool output = false;
                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }

        public async Task LogIn()
        {
            var result = await _apihelper.Authenticates(UserName, Password);
        }
    }
}