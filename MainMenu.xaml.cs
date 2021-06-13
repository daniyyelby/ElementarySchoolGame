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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void KindergartenClick(object sender, RoutedEventArgs e)
        {
           // NavigationService nav = NavigationService.GetNavigationService(this);
            //nav.Navigate(new Uri("Kindergarten.xaml", UriKind.RelativeOrAbsolute));
          //  nav.Navigate(typeof(Kindergarten));

            //   Kindergarten kindergarten = 

            GradeMenuButton.IsEnabled = false;
            GradeMenuButton2.IsEnabled = true;
            GradeMenuButton3.IsEnabled = false;

            this.NavigationService.Navigate(new Uri("Kindergarten.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            Kindergarten newpage = new Kindergarten();
            this.NavigationService.Navigate(newpage);

        }

        private void PreKClick(object sender, RoutedEventArgs e)
        {
           // NavigationService nav1 = NavigationService.GetNavigationService(this);
            //nav1.Navigate(new Uri("PreK.xaml", UriKind.RelativeOrAbsolute));

            //nav1.Navigate(typeof(PreK));

            GradeMenuButton.IsEnabled = false;
            GradeMenuButton2.IsEnabled = false;
            GradeMenuButton3.IsEnabled = true;

            this.NavigationService.Navigate(new Uri("PreK.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreK newpage = new PreK();
            this.NavigationService.Navigate(newpage);
        }

        private void Onegradeclick(object sender, RoutedEventArgs e)
        {
          //  NavigationService nav2 = NavigationService.GetNavigationService(this);
            //nav2.Navigate(new Uri("1grade.xaml", UriKind.RelativeOrAbsolute));

            this.NavigationService.Navigate(new Uri("1grade.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            _1grade newpage = new _1grade();
            this.NavigationService.Navigate(newpage);

            //nav2.Navigate(typeof(_1grade));
            GradeMenuButton.IsEnabled = true;
            GradeMenuButton2.IsEnabled = false;
            GradeMenuButton3.IsEnabled = false;


        }
    }
}
