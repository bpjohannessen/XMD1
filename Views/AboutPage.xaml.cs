using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XMD1.ViewModels;

namespace XMD1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel(Navigation);
        }
    }
}