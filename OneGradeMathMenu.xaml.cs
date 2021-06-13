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
    /// Interaction logic for OneGradeMathMenu.xaml
    /// </summary>
    public partial class OneGradeMathMenu : Page
    {
        public OneGradeMathMenu()
        {
            InitializeComponent();
        }

        private void OneGradeMath2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OneGradeSubtraction.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            OneGradeSubtraction newpage = new OneGradeSubtraction();
            this.NavigationService.Navigate(newpage);
        }

        private void OneGradeMath1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OnegradeAddition.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            OnegradeAddition newpage = new OnegradeAddition();
            this.NavigationService.Navigate(newpage);
        }
    }
}
