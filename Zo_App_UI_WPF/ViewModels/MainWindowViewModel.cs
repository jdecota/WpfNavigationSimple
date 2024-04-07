using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zo_App_UI_WPF.Stores;

namespace Zo_App_UI_WPF.ViewModels
{
   public class MainWindowViewModel : ViewModelBase
   {
         private readonly NavigationStore _navigationStore;

         // CurrentViewModel- Get from NavigationStore -
         // Delegate this prop to NavigationStore Property
         public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

         public MainWindowViewModel(NavigationStore navigationStore)
         {
            _navigationStore = navigationStore;

            // Note-VM:  Subscribe to class's property changed event
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

         }
         private void OnCurrentViewModelChanged()
         {
            OnPropertyChanged(nameof(CurrentViewModel));
         }
      }
   }
