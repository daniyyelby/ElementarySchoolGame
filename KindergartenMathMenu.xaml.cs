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
    /// Interaction logic for KindergartenMathMenu.xaml
    /// </summary>
    public partial class KindergartenMathMenu : Page
    {
        public KindergartenMathMenu()
        {
            InitializeComponent();
        }

        private void KindergartenMath2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("KindergartenSubtraction.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            KindergartenSubtraction newpage = new KindergartenSubtraction();
            this.NavigationService.Navigate(newpage);
        }

        private void KindergartenMath1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Atry.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            Atry newpage = new Atry();
            this.NavigationService.Navigate(newpage);
        }
    }
}
