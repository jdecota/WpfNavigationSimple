using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zo_App_UI_WPF.Commands
{
   public abstract class CommandBase : ICommand
   {
      public event EventHandler CanExecuteChanged;

      public virtual bool CanExecute(object parameter)
      {
         return true;
      }

      public abstract void Execute(object parameter);

      protected virtual void OnCanExecutedChanged()
      {
         CanExecuteChanged?.Invoke(this, new EventArgs());
      }
   }
}
