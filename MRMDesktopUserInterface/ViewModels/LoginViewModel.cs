using Caliburn.Micro;
using MRMDesktopUserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRMDesktopUILibrary.API;
using MRMDesktopUserInterface.EventsModels;

namespace MRMDesktopUserInterface.ViewModels
{

    public class LoginViewModel : Screen
    {
        private String _username;
        private String _password;
        private IAPIHelper _apihelper;
        private IEventAggregator _events;

        public LoginViewModel(IAPIHelper apihelper, IEventAggregator events)
        {
            _apihelper = apihelper;
            _events = events;
        }
        public String UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }


        public String Password
        {
            get { return _password; }
            set
            {
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
        public Boolean IsErrorVisible
        {
            get
            {
                Boolean output = false;
                if (ErrorMessage?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }

        private string _ErrorMessage;

        public string ErrorMessage
        {
            get { return _ErrorMessage; }
            set
            {
                _ErrorMessage = value;
                NotifyOfPropertyChange(() => ErrorMessage);
                NotifyOfPropertyChange(() => IsErrorVisible);
             
            }
        }

        public async Task LogIn()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apihelper.Authenticates(UserName, Password);
                await _apihelper.GetLoggedInUsreInfo(result.Access_Token);
                
                _events.PublishOnUIThread(new LogOnEvent());
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
