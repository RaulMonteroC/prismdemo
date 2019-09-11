using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismDemo.Keys;
using PrismDemo.ViewModels;
using PrismDemo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismDemo
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            await NavigationService.NavigateAsync(NavKeys.MainPage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();

            containerRegistry.RegisterForNavigation<GrettingsPage>();
            containerRegistry.RegisterForNavigation<GrettingsSpanishPage>();
            containerRegistry.RegisterForNavigation<GrettingsEnglishPage,GrettingsEnglishViewModel>();
            containerRegistry.RegisterForNavigation<GrettingsFrenchPage>();

            containerRegistry.RegisterForNavigation<GoodbyePage, GoodbyeViewMode>();
        }
    }
}
