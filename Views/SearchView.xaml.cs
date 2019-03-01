using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XMD1.ViewModels;

namespace XMD1.Views
{
    public partial class SearchView : ContentPage
    {
        public SearchView(SearchViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}