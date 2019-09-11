using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using PrismDemo.Keys;

namespace PrismDemo.ViewModels
{
    public class GoodbyeViewMode : BaseViewModel, INavigationAware
    {
        public string Goodbye { get; set; }

        public DelegateCommand GoBackCommand { get; set; }

        private readonly INavigationService _navigationService;

        public GoodbyeViewMode(INavigationService navigationService)
        {
            _navigationService = navigationService;
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            GoBackCommand = new DelegateCommand(async () => await GoBack());
        }

        private async Task GoBack()
        {
            await _navigationService.GoBackAsync();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var name = parameters[ParamKeys.GoodbyeName] as string;

            Goodbye = $"Goodbye {name}";
        }
    }
}
