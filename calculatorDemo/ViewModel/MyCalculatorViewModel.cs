using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace calculatorDemo
{
    public class MyCalculatorViewModel : BaseViewModel
    {
        string _bttnText;
        public string BttnText
        {
            get { return _bttnText; }
            set { SetProperty(ref _bttnText, value); }
        }

        public ICommand NavgCommand
        {
            get { return new Command(HandleNavgAction); }
        }

        private void HandleNavgAction(object obj)
        {
            var a = "b";
            ///Navigate from this place...
            ///
        }

        public MyCalculatorViewModel()
        {
            BttnText = "View Model Bttn";


        }

    }
}
