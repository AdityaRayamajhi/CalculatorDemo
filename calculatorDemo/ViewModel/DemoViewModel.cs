using System;
using System.Collections.ObjectModel;
using calculatorDemo.Model;
using Xamarin.Forms;

namespace calculatorDemo.ViewModel
{
    public class DemoViewModel : BaseViewModel
    {
        private NavigationPage _navPage;

        public DemoViewModel(Page page)
        {
            _navPage = new NavigationPage(page);
            ItemSource = GetListSource();
        }

        ObservableCollection<Item> _items;
        public ObservableCollection<Item> ItemSource
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        private ObservableCollection<Item> GetListSource()
        {
            var sourcelist = new ObservableCollection<Item>()
            {
                new Item() { LabelText= "Item1", ButtonLabel= "Bttn1"},
                new Item() { LabelText= "Item2", ButtonLabel= "Bttn2"},
                new Item() { LabelText= "Item3", ButtonLabel= "Bttn3"},
                new Item() { LabelText= "Item4", ButtonLabel= "Bttn4"},
                new Item() { LabelText= "Item5", ButtonLabel= "Bttn5"},
                new Item() { LabelText= "Item6", ButtonLabel= "Bttn6"},
                new Item() { LabelText= "Item7", ButtonLabel= "Bttn7"},
                new Item() { LabelText= "Item8", ButtonLabel= "Bttn8"},
                new Item() { LabelText= "Item9", ButtonLabel= "Bttn9"},
                new Item() { LabelText= "Item10", ButtonLabel= "Bttn10"}
            };

            return sourcelist;
        }

        //private ObservableCollection<string> GetListSource()
        //{
        //    var sourcelist = new ObservableCollection<string>()
        //    {
        //       "Item1",
        //       "Item2",
        //       "Item3",
        //       "Item4",
        //       "Item5",
        //       "Item6",
        //       "Item7",
        //       "Item8",
        //       "Item9",
        //       "Item10"
        //    };

        //    return sourcelist;
        //}
    }
}
