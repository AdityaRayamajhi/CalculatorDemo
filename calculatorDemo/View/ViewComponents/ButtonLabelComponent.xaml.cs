using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace calculatorDemo.View.ViewComponents
{
    public partial class ButtonLabelComponent : ContentView
    {
        public static readonly BindableProperty ComponentLabelTextProperty =
            BindableProperty.Create(nameof(ComponentLabelText), typeof(string), typeof(ButtonLabelComponent), defaultBindingMode:BindingMode.TwoWay);
        public static readonly BindableProperty ComponentBttnTextProperty =
            BindableProperty.Create(nameof(ComponentBttnText), typeof(string), typeof(ButtonLabelComponent), defaultBindingMode: BindingMode.TwoWay);

        public string ComponentLabelText
        {
            get { return (string) GetValue(ComponentLabelTextProperty); }
            set { SetValue(ComponentLabelTextProperty, value); }
        }

        public string ComponentBttnText
        {
            get { return (string)GetValue(ComponentBttnTextProperty); }
            set { SetValue(ComponentBttnTextProperty, value); }
        }

        public ButtonLabelComponent()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
