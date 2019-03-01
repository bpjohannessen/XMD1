using System;
namespace XMD1.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {

        private string _label;
        public string Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged("Label");
            }
        }

        public SearchViewModel(string key)
        {
            // Do whatever you want to do
            Label = key;
        }


    }
}
