using System.Configuration;
using System.Data;
using System.Windows;

using Zo_App_UI_WPF.Stores;
using Zo_App_UI_WPF.ViewModels;

namespace Zo_App_UI_WPF
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application
   {

      protected override void OnStartup(StartupEventArgs e)
      {
         NavigationStore navigationStore = new NavigationStore();

         // Set INITIAL CurrentViewModel window
         //navigationStore.CurrentViewModel = new LayoutView_MainViewModel(navigationStore);
         navigationStore.CurrentViewModel = new StartPageViewModel(navigationStore);

         MainWindow = new MainWindow()
         {
            DataContext = new MainWindowViewModel(navigationStore)
         };

         //MainWindow = new MainWindow();

         MainWindow.Show();

         base.OnStartup(e);
      }
   }

}
