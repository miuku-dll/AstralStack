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

namespace Kill_yourself_1.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();



        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Overwatch\\Overwatch Launcher.exe");
        }

        private void Bookmark1_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Bookmark1);
            }
            catch
            {
                MessageBox.Show("Error 104");
            }
        }

        private void Bookmark2_Clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Battle.net\\Battle.Net Launcher.exe");
        }
    }
}
