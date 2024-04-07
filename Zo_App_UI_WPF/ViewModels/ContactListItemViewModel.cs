using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zo_App_UI_WPF.ViewModels
{
   public class ContactListItemViewModel : ViewModelBase
   {
      public string Username { get; }
      
      // TODO: Action Menu 
      public ICommand EditCommand {  get; }
      public ICommand DeleteCommand { get; }


      public ContactListItemViewModel(string username) 
      { 
         Username = username;
      }
   }
}
