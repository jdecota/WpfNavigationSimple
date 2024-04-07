using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zo_App_UI_WPF.ViewModels
{
   public class ContactListViewModel : ViewModelBase
   {
      // Note-Items:  List VM of Items
      /*  ObservableCollection field
       *  Exposing it as an iEnumerable 
       *    (basically encapsulating this observable collection which means all the viewmodels that 
       *    we add/remove/change is going to be done within this v model
       *    Instantiate this ObservableCollection in ctor- make it empty for now;  going to hard code some data in here 
       */
     
      private readonly ObservableCollection<ContactListItemViewModel> _contactListItemViewModels;
      public IEnumerable<ContactListItemViewModel> ContactListItemViewModels => _contactListItemViewModels;

        public ContactListViewModel()
        {
          _contactListItemViewModels = new ObservableCollection<ContactListItemViewModel>();
         _contactListItemViewModels.Clear();

         _contactListItemViewModels.Add(new ContactListItemViewModel("Quinn"));
         _contactListItemViewModels.Add(new ContactListItemViewModel("Brecken"));
         _contactListItemViewModels.Add(new ContactListItemViewModel("Adam"));
      }
    }
}
