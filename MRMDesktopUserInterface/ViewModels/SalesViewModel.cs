using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRMDesktopUserInterface.ViewModels
{
    class SalesViewModel : Screen
    {

        private BindingList<string> _product;

        public BindingList<string> Products
        {
            get { return _product; }
            set
            {
                _product = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private string _itenQuantity;

        public string ItemQuantity
        {
            get { return _itenQuantity; }
            set
            {
                _itenQuantity = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public string SubTotal
        {
            get
            {
                //Replace with calculations
                return "$0.00";
            }

        }

        public string Tax
        {
            get
            {
                //Replace with calculations
                return "$0.00";
            }

        }

        public string Total
        {
            get
            {
                //Replace with calculations
                return "$0.00";
            }

        }
        public bool CanAddToCart
        {
            get
            {
                bool output = false;
             //Make sure something is selected
             //make sure there is an item quatity
                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;
                //Make sure something is selected
                //make sure there is an item quatity
                return output;
            }
        }

        public void CheckOut()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;
                //Make sure something is selected
                //make sure there is an item quatity
                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

    }
}
