using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAppFirstTry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void ButtonClickMainMenu(object sender, RoutedEventArgs e)
        {
           // NavigationService nav1 = NavigationService.GetNavigationService(this);
            //nav1.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));

            //MainMenu mainmenu = new MainMenu();
           // this.Content = mainmenu; 

            Main.Content = new MainMenu();
        }

    }
}
