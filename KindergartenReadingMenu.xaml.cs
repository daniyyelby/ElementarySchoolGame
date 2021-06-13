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
    /// Interaction logic for KindergartenReadingMenu.xaml
    /// </summary>
    public partial class KindergartenReadingMenu : Page
    {
        public KindergartenReadingMenu()
        {
            InitializeComponent();
        }

        private void KindergartenReading2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("KindergartenAbc.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            KindergartenAbc newpage = new KindergartenAbc();
            this.NavigationService.Navigate(newpage);
        }

        private void KindergartenReading1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("KindergartenFillInBlank.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            KindergartenFillInBlank newpage = new KindergartenFillInBlank();
            this.NavigationService.Navigate(newpage);
        }

        
    }
}
