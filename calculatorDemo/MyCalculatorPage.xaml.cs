using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace calculatorDemo
{
    public partial class MyCalculatorPage : ContentPage
    {
        public string BttnText { get; set; }

        public MyCalculatorPage()
        {
            InitializeComponent();

            BindingContext = new MyCalculatorViewModel();
        }

        //void NavgAction(System.Object sender, System.EventArgs e)
        //{
        //    Navigation.PushAsync(new MainPage());
        //}
    }
}
