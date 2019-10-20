using Microsoft.Win32;
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
using Twilio.TwiML.Messaging;


namespace Bot_UI_New
{
    /// <summary>
    /// Логика взаимодействия для UserControlTextVideo.xaml
    /// </summary>
    public partial class UserControlTextVideo : UserControl
    {
        

        public UserControlTextVideo()
        {
            InitializeComponent();
        }

        private void OpenVideo(object sender, RoutedEventArgs e)
        {
            OpenFileDialog video = new OpenFileDialog();

            video.Filter = "Image Files(*.AVI;*.MKV;*.MOV;*.FLV;*.VOB;*.MP4;)|*.AVI;*.MKV;*.MOV;*.FLV;*.VOB;*.MP4;";

            if (video.ShowDialog() == true)
            {
                MediaElement.Source = new Uri(video.FileName);
                MediaElement.Pause();
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Play();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (MediaElement.CanPause)
                MediaElement.Pause();
            
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Stop();
        }

        
    }
}
