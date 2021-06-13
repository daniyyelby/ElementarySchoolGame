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
    /// Interaction logic for OneGradeReadingMenu.xaml
    /// </summary>
    public partial class OneGradeReadingMenu : Page
    {
        public OneGradeReadingMenu()
        {
            InitializeComponent();
        }

        private void OneGradeReading2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OneGradeAbc.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            OneGradeAbc newpage = new OneGradeAbc();
            this.NavigationService.Navigate(newpage);
        }

        private void OneGradeReading1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OneGradeFillInBlank.xaml", UriKind.Relative));

            //Navigate to an instance of a page.
            OneGradeFillInBlank newpage = new OneGradeFillInBlank();
            this.NavigationService.Navigate(newpage);
        }

        
    }
}
