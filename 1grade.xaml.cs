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
    /// Interaction logic for _1grade.xaml
    /// </summary>
    public partial class _1grade : Page
    {
        public _1grade()
        {
            InitializeComponent();
        }

        private void GradeSubject2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OneGradeMathMenu.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            OneGradeMathMenu newpage = new OneGradeMathMenu();
            this.NavigationService.Navigate(newpage);
        }

        private void GradeSubject1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OneGradeReadingMenu.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            OneGradeReadingMenu newpage = new OneGradeReadingMenu();
            this.NavigationService.Navigate(newpage);
        }
    }
}
