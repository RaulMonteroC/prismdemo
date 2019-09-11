using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using PrismDemo.Keys;

namespace PrismDemo.ViewModels
{
    public class GrettingsEnglishViewModel : BaseViewModel
    {
        public DelegateCommand NavigateToGoodbyePageCommand { get; set; }

        private readonly INavigationService _navigationService;
        public GrettingsEnglishViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            RegisterCommands();
        }

        private void RegisterCommands()
        {
            NavigateToGoodbyePageCommand = new DelegateCommand(async () => await NavigateToGoodbyePage());
        }

        private async Task NavigateToGoodbyePage()
        {
            await _navigationService.NavigateAsync(NavKeys.GoodbyePage, new NavigationParameters()
            {
                {ParamKeys.GoodbyeName, "Xamarin"}
            });
        }
    }
}
