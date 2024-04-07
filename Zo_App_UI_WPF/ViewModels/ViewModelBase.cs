using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Zo_App_UI_WPF.ViewModels
{
   public class ViewModelBase : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      // Note-VM:  ViewModelBase Setup
      // Note-VM:  Helper Method OnPropertyChanged
      // Note-VM: ViewModelBase: Make virtual in case we have to override 
      // Note-VM:  Can use [CallerMemberName] if don't want to pass in property every time
      // Note-VM:  CallerMemberName - protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      protected virtual void OnPropertyChanged(string propertyName = null)
      {
         // Note-VM:  Hover Note indicates propertyName is optional so can put null; if null, will raise property changed and the UI will grab everything that it's binding to not just a specific property
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

      protected virtual void Dispose() { }
   }
}
