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
    /// Interaction logic for PreK.xaml
    /// </summary>
    public partial class PreK : Page
    {
        public PreK()
        {
            InitializeComponent();
        }

        private void PreKSubject2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PreKMathMenu.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreKMathMenu newpage = new PreKMathMenu();
            this.NavigationService.Navigate(newpage);
        }

        private void PreKSubject1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PreKReadingMenu.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreKReadingMenu newpage = new PreKReadingMenu();
            this.NavigationService.Navigate(newpage);
        }
    }
}
