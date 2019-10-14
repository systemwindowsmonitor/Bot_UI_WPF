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

namespace Bot_UI_New
{
    /// <summary>
    /// Логика взаимодействия для UserControlText.xaml
    /// </summary>
    public partial class UserControlText : UserControl
    {
        public string text;
        public UserControlText()
        {
            InitializeComponent();
            
        }

        private void TextUser_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void TextUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            text = this.TextUser.Text;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TextUser.MaxHeight = TextUser.Height =  550;
        }
    }
}
