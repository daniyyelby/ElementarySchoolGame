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
    /// Interaction logic for Kindergarten.xaml
    /// </summary>
    public partial class Kindergarten : Page
    {
        public Kindergarten()
        {
            InitializeComponent();
        }

        private void KindergartenSubject2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("KindergartenMathMenu.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            KindergartenMathMenu newpage = new KindergartenMathMenu();
            this.NavigationService.Navigate(newpage);
        }

        private void KindergartenSubject1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("KindergartenReadingMenu.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            KindergartenReadingMenu newpage = new KindergartenReadingMenu();
            this.NavigationService.Navigate(newpage);
        }
    }
}
