using CredentialManagement;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Bot_UI_New
{
    /// <summary>
    /// Логика взаимодействия для TexAndImage.xaml
    /// </summary>
    public partial class TexAndImage : UserControl
    {
        public TexAndImage()
        {
            InitializeComponent();
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();

            img.Filter = "Image Files(*.JPG;*.JPEG;*.PNG;*.BMP;)|*.JPG;*.JPEG;*.PNG;*.BMP;";

            if (img.ShowDialog() == true)
            {
                Img.Source = new BitmapImage(new Uri(img.FileName));
            }

        }
    }
}
