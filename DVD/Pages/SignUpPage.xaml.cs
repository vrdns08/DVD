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

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txb_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());

        }

        private void txb_MouseEnter(object sender, MouseEventArgs e)
        {
            txb.Foreground=new SolidColorBrush(Colors.Red);
        }

        private void txb_MouseLeave(object sender, MouseEventArgs e)
        {
            txb.Foreground = new SolidColorBrush(Colors.White);
        }
    }
}
