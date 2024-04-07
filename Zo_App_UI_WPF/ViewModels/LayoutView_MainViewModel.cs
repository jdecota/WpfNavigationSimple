using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Zo_App_UI_WPF.Commands;
using Zo_App_UI_WPF.Stores;

namespace Zo_App_UI_WPF.ViewModels
{
    public class LayoutView_MainViewModel : ViewModelBase
    {
      public ContactListViewModel ContactListViewModel { get; }
      public ContactDetailsViewModel ContactDetailsViewModel { get; }

      public ICommand NavigateStartPageViewCommand { get; }
      public ICommand AddContactCommand { get; }

      // Note-Nav:  ViewModel needs NavStore passed in so can use NavigateStartPageViewCommand
        public LayoutView_MainViewModel(NavigationStore navigationStore)
        {
         ContactListViewModel = new ContactListViewModel();
         ContactDetailsViewModel = new ContactDetailsViewModel();

         NavigateStartPageViewCommand = new NavigateStartPageViewCommand(navigationStore);
        }


    }
}
