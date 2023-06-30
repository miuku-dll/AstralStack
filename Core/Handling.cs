using Kill_yourself_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kill_yourself_1.MVVM.View;
using System.IO;

namespace KYS.Core
{
    internal class Handling
    {

        // Error Handling

        public static void Error101()
        {
            MessageBox.Show("Error 101"); //Failed to find a executeable to save
        }

        public static void Error102()
        {
            MessageBox.Show("Error 102"); //Failed to save executeable to config
        }

        public static void Error103()
        {
            MessageBox.Show("Error 103"); //Failed to start bookmarked application
        }

        public static void Error104()
        {
            MessageBox.Show("Error 104"); //Failed to bookmark application
        }

        public static void Error105()
        {
            MessageBox.Show("Error 105"); //Failed to copy bookmark image
        }


        // Config Handling

        public static void QuickSave()
        {
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        public static void Reload()
        {
            Settings.Default.Reload();
        }

        // Bookmark Handling

        public static void BookmarkImg1()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".exe";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                var PickedImg = dlg.FileName; // Picking Bookmark 1 img
                try
                {
                    File.Copy(PickedImg, "./Images/Blob11.png");
                    MessageBox.Show("Please restart your app!");
                }
                catch
                {
                    Error105();

                    if (MessageBox.Show("Please delete the file Blob11.png and try again", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

    }
}
