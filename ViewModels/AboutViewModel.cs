using System;
using System.Windows.Input;

using Xamarin.Forms;
using XMD1.Views;

namespace XMD1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        //private string _searchKey;
        //public string SearchKey
        //{
        //    get => _searchKey;
        //    set
        //    {
        //        _searchKey = value;
        //        OnPropertyChanged("SearchKey");
        //    }
        //}

        public AboutViewModel(INavigation navigation)
        {
            Title = "About";

            OpenSearch = new Command<string>((SearchKey) => navigation.PushAsync(new SearchView(new SearchViewModel(SearchKey))));
        }

        public ICommand OpenSearch { get; }
    }
}