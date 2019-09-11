using System;
using System.ComponentModel;
using Prism.Mvvm;
using PropertyChanged;

namespace PrismDemo.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
