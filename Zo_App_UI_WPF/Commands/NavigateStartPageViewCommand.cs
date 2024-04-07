using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zo_App_UI_WPF.Stores;
using Zo_App_UI_WPF.ViewModels;

namespace Zo_App_UI_WPF.Commands
{
    public class NavigateStartPageViewCommand : CommandBase
    {

      private readonly NavigationStore _navigationStore;

      public NavigateStartPageViewCommand(NavigationStore navigationStore)
      {
         _navigationStore = navigationStore;
      }
      public override void Execute(object parameter)
      {
         _navigationStore.CurrentViewModel = new StartPageViewModel(_navigationStore);
      }

   }
}
