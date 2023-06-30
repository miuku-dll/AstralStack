using Kill_yourself_1.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kill_yourself_1.MVVM.View;
using KYS.Core;

namespace Kill_yourself_1.MVVM.View
{
    public partial class SecondaryView : UserControl
    {
        public SecondaryView()
        {
            Directory.CreateDirectory("Images");
            InitializeComponent();
        }

        // Useful

        private string Picked = string.Empty; // For application picking

        public void FilePick()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".exe";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                Picked = dlg.FileName; // Stating what application is picked
            }
        }


        // Error handling

        

        // General

        private void ow2_Clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Overwatch\\Overwatch Launcher.exe");
        }

        private void cs_Clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Steam\\Steam.exe");
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SettingsBtn.IsChecked == true)
            {
                this.Blob1.Visibility = Visibility.Visible; // Just ewww
                this.Blob2.Visibility = Visibility.Visible;
                this.Blob3.Visibility = Visibility.Visible;
                this.Blob4.Visibility = Visibility.Visible;

                this.Blob5.Visibility = Visibility.Visible;
                this.Blob6.Visibility = Visibility.Visible;
                this.Blob7.Visibility = Visibility.Visible;
                this.Blob8.Visibility = Visibility.Visible;
            }
            else
            {
                this.Blob1.Visibility = Visibility.Hidden;
                this.Blob2.Visibility = Visibility.Hidden;
                this.Blob3.Visibility = Visibility.Hidden;
                this.Blob4.Visibility = Visibility.Hidden;

                this.Blob5.Visibility = Visibility.Hidden;
                this.Blob6.Visibility = Visibility.Hidden;
                this.Blob7.Visibility = Visibility.Hidden;
                this.Blob8.Visibility = Visibility.Hidden;
            }
        }

        private void SettingsBtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void BlobBookmark1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob1Path;
                Settings.Default.Bookmark1Img = "Blob1.png";
                MessageBox.Show("Bookmarked Blob1");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error103();
            }
        }

        private void FileBtn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob1Path = Picked;
                MessageBox.Show("Saved Blob1");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }

        private void Blob1_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob1Path);
            }
            catch
            {
                Handling.Error101();
            }
            
        }

        private void Blob2_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob2Path);
            }
            catch
            {
                Handling.Error101();
            }

        }

        private void BlobBookmark2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob2Path;
                Settings.Default.Bookmark1Img = "Blob2.png";
                MessageBox.Show("Bookmarked Blob2");
                Handling.QuickSave();

            }
            catch
            {
                Handling.Error103();
            }
        }

        private void FileBtn2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob2Path = Picked;
                MessageBox.Show("Saved Blob2");
                Handling.QuickSave();

            }
            catch
            {
                Handling.Error101();
            }
        }


        private void Blob3_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob3Path);
            }
            catch
            {
                Handling.Error101();
            }

        }

        private void BlobBookmark3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob3Path;
                Settings.Default.Bookmark1Img = "Blob3.png";
                MessageBox.Show("Bookmarked Blob3");
                Handling.QuickSave();

            }
            catch
            {
                Handling.Error103();
            }
        }

        private void FileBtn3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob3Path = Picked;
                MessageBox.Show("Saved Blob3");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }

        private void Blob4_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob4Path);
            }
            catch
            {
                Handling.Error101();
            }

        }

        private void BlobBookmark4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob4Path;
                Settings.Default.Bookmark1Img = "Blob4.png";
                MessageBox.Show("Bookmarked Blob4");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error103();
            }
        }

        public void FileBtn4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob4Path = Picked;
                MessageBox.Show("Saved Blob4");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }

        private void Blob5_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob5Path);
            }
            catch
            {
                    Handling.Error101();
            }

        }

        private void BlobBookmark5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob5Path;
                Settings.Default.Bookmark1Img = "Blob5.png";
                MessageBox.Show("Bookmarked Blob5");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error103();
            }
        }


        public void FileBtn5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob5Path = Picked;
                MessageBox.Show("Saved Blob5");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }

        private void Blob6_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob6Path);
            }
            catch
            {
                Handling.Error101();
            }

        }

        private void BlobBookmark6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob6Path;
                Settings.Default.Bookmark1Img = "Blob6.png";
                MessageBox.Show("Bookmarked Blob6");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error103();
            }
        }

        public void FileBtn6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob6Path = Picked;
                MessageBox.Show("Saved Blob6");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }

        private void Blob7_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob7Path);
            }
            catch
            {
                Handling.Error101();
            }

        }

        private void BlobBookmark7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob7Path;
                Settings.Default.Bookmark1Img = "Blob7.png";
                MessageBox.Show("Bookmarked Blob7");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error103();
            }
        }

        public void FileBtn7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob7Path = Picked;
                MessageBox.Show("Saved Blob7");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }

        private void Blob8_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.Blob8Path);
            }
            catch
            {
                Handling.Error101();
            }

        }
        private void BlobBookmark8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Bookmark1 = Properties.Settings.Default.Blob8Path;
                Settings.Default.Bookmark1Img = "Blob8.png";

                MessageBox.Show("Bookmarked Blob8");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error103();
            }
        }

        public void FileBtn8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FilePick();
                Settings.Default.Blob8Path = Picked;
                MessageBox.Show("Saved Blob8");
                Handling.QuickSave();
            }
            catch
            {
                Handling.Error101();
            }
        }
    }

}
