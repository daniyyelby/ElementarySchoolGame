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
    /// Interaction logic for PreKReadingMenu.xaml
    /// </summary>
    public partial class PreKReadingMenu : Page
    {
        public PreKReadingMenu()
        {
            InitializeComponent();
        }

        private void PreKReading2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PreKAbc.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreKAbc newpage = new PreKAbc();
            this.NavigationService.Navigate(newpage);
        }

        private void PreKReading1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PreKFillInBlank.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreKFillInBlank newpage = new PreKFillInBlank();
            this.NavigationService.Navigate(newpage);
        }

        
    }
}
