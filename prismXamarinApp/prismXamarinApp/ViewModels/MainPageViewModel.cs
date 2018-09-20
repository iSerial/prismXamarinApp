using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prismXamarinApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private DelegateCommand gotoMyFirstPageCommand;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }
        public DelegateCommand GotoMyFirstPageCommand => gotoMyFirstPageCommand 
            ?? (gotoMyFirstPageCommand = new DelegateCommand(GotoMyFirstPage, CanGotoMyFirstPage));

        private bool CanGotoMyFirstPage()
        {
            return true;
        }

        private void GotoMyFirstPage()
        {
            _navigationService.NavigateAsync("myFirstContentPage");
        }
    }
}
