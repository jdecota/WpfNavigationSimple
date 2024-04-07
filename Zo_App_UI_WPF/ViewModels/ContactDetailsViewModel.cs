using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zo_App_UI_WPF.ViewModels
{
   public class ContactDetailsViewModel : ViewModelBase
   {
      // Note-VM:  45:00ish tutorial https://www.youtube.com/watch?v=54ZmhbpjBmg&list=PLA8ZIAm2I03hm1xwjWWE_gLLNpqJA3E3j&index=1

      public string Username { get; }
      public string IsSubscribedDisplay { get; }
      public string IsMemberDisplay { get; }


      public ContactDetailsViewModel()
      {
         Username = "Jen";
         IsSubscribedDisplay = "Subscribed";
         IsMemberDisplay = "No";
      }

   }
}
