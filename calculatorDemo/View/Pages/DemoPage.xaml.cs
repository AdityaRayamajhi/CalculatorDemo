using calculatorDemo.ViewModel;
using Xamarin.Forms;

namespace calculatorDemo
{
    public partial class DemoPage : ContentPage
    {
        public DemoPage()
        {
            InitializeComponent();
            BindingContext = new DemoViewModel(this);
        }
    }
}
