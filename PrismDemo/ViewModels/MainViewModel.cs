using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using PrismDemo.Keys;

namespace PrismDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public DelegateCommand NavigateToGreetingsPageCommand { get; set; }

        private readonly INavigationService _navigationService;
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            RegisterCommands();
        }

        private void RegisterCommands()
        {
            NavigateToGreetingsPageCommand = new DelegateCommand(async () => await NavigateToGreetingsPage());
        }

        private async Task NavigateToGreetingsPage()
        {
            await _navigationService.NavigateAsync(NavKeys.GrettingsPage);
        }

    }
}
