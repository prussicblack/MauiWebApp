using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWebApp
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _url = "http://192.168.0.48";

        public string Url
        {
            get => _url;
            set
            {
                if (_url != value)
                {
                    _url = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Url)));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
