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

namespace Kill_yourself_1.MVVM.View
{
    /// <summary>
    /// Interaction logic for SecondaryView.xaml
    /// </summary>
    public partial class SecondaryView : UserControl
    {
        public SecondaryView()
        {
            Directory.CreateDirectory("Images");
            InitializeComponent();
        }

        



private void ow2_Clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Overwatch\\Overwatch Launcher.exe");
        }

        private void cs_Clicked(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Steam\\Steam.exe");
        }

        private void FileBtn_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".exe";

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                SelectedFileTXTBox.Text = filename;
            }
        }

        private void First_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(SelectedFileTXTBox.Text);

            }
            catch
            { }
                
        }


        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SettingsBtn.IsChecked == true)
            {
                this.Blob1.Visibility = Visibility.Visible;
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


        private void SaveBlob1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob1Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob1");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob2Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob2");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob3Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob3");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob4Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob4");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob5Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob5");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob6Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob6");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob7Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob7");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
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
                MessageBox.Show("Error 101");
            }

        }

        private void SaveBlob8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Settings.Default.Blob8Path = SelectedFileTXTBox.Text;
                MessageBox.Show("Saved Blob8");
                Settings.Default.Save();
                Settings.Default.Reload();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
