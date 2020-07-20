using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using MRMDesktopUserInterface.EventsModels;

namespace MRMDesktopUserInterface.ViewModels
{
   public  class ShellViewModel:Conductor<Object>,IHandle<LogOnEvent>
    {
      
        private IEventAggregator _eventa;
        private SalesViewModel _SalesVM;
        private SimpleContainer _container;
        public ShellViewModel(SimpleContainer container, IEventAggregator events, SalesViewModel SalesVM)
        {
            _eventa = events;
            _SalesVM = SalesVM;
            _container = container;
            _eventa.Subscribe(this);
            ActivateItem(_container.GetInstance<LoginViewModel>()); //Using Calliburn Micro

        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_SalesVM);
        }
    }
}
