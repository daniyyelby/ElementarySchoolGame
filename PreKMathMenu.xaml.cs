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
    /// Interaction logic for PreKMathMenu.xaml
    /// </summary>
    public partial class PreKMathMenu : Page
    {
        public PreKMathMenu()
        {
            InitializeComponent();
        }

        private void PreKMath2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PreKSubtraction.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreKSubtraction newpage = new PreKSubtraction();
            this.NavigationService.Navigate(newpage);
        }

        private void PreKMath1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("PreKAddition.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            PreKAddition newpage = new PreKAddition();
            this.NavigationService.Navigate(newpage);
        }
    }
}
