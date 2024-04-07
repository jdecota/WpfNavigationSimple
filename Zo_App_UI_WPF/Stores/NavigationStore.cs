﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zo_App_UI_WPF.ViewModels;

namespace Zo_App_UI_WPF.Stores
{
   public class NavigationStore
   {

      private ViewModelBase _currentViewModel;
      public ViewModelBase CurrentViewModel
      {
         get => _currentViewModel;
         set
         {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
         }
      }

      public event Action CurrentViewModelChanged;
      private void OnCurrentViewModelChanged()
      {
         CurrentViewModelChanged?.Invoke();
      }
   }
}
