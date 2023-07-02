using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using Kill_yourself_1.MVVM.View;
using Kill_yourself_1.Properties;
using KYS.Core;

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
                Handling.Error103();
            }
        }

        private void Bookmark2_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Handling.BookmarkImg1();
            }
            catch
            {
                Handling.Error103();
            }
        }

        private void Bookmark1Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Handling.BookmarkImg1();
            }
            catch
            {
                Handling.Error103();
            }
        }

        private void Bookmark2Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Handling.BookmarkImg1();
            }
            catch
            {
                Handling.Error103();
            }
        }

        private void SettingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            if (SettingsBtn2.IsChecked == true)
            {
                this.Blob1.Visibility = Visibility.Visible; // Just ewww
                this.Blob2.Visibility = Visibility.Visible;
                this.Blob3.Visibility = Visibility.Visible;
            }
            else
            {
                this.Blob1.Visibility = Visibility.Hidden;
                this.Blob2.Visibility = Visibility.Hidden;
                this.Blob3.Visibility = Visibility.Hidden;
            }
        }
    }
}
