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
    public class StartPageViewModel : ViewModelBase
    {
      public ICommand NavigateLayoutViewCommand { get; }

      // Note-Nav:  Passing but not setting here so do not need NavStore here
      public StartPageViewModel(NavigationStore navigationStore) 
      {
         NavigateLayoutViewCommand = new NavigateLayoutViewCommand(navigationStore);
      }
    }
}