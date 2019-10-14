using Bot_UI_New.ViewModel;
using Diet_Center_Bot;
using MaterialDesignThemes.Wpf;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SubItem> menuSchedule = new List<SubItem>();
        public MainWindow()
        {
            InitializeComponent();
            Bot.getBot().startReceiving();
            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("Опрос да / нет с документом"));
            menuRegister.Add(new SubItem("Опрос да / нет с видео"));
            menuRegister.Add(new SubItem("Опрос да / нет с фото"));
            menuRegister.Add(new SubItem("Опрос да / нет"));
            menuRegister.Add(new SubItem("Опрос с документом (1 - 5 \nответов)"));
            menuRegister.Add(new SubItem("Опрос с видео (1 - 5 ответов)"));
            menuRegister.Add(new SubItem("Опрос (1 - 5 ответов)"));
            var item1 = new ItemMenu("Опросы", menuRegister, PackIconKind.Poll);

          
            menuSchedule.Add(new SubItem("Текст с видео", new UserControlTextVideo()));
            menuSchedule.Add(new SubItem("Текст с документом"));
            menuSchedule.Add(new SubItem("Текст с геолокацией"));
            menuSchedule.Add(new SubItem("Текст с опросом Да/Нет"));
            menuSchedule.Add(new SubItem("Текст с ссылкой"));
            menuSchedule.Add(new SubItem("Текст с картинкой"));
            menuSchedule.Add(new SubItem("Простой текст", new UserControlText()));
            var item2 = new ItemMenu("Тексты", menuSchedule, PackIconKind.Text);

            var menuFinancial = new List<SubItem>();
            menuFinancial.Add(new SubItem("Создать"));
            var item3 = new ItemMenu("Пустой шаблон", menuFinancial, PackIconKind.Edit);

            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        private void Send_Click_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count != 0)
            {
                if (menuSchedule[6].Screen is UserControlText)
                {
                    string s = (menuSchedule[6].Screen as UserControlText).text;
                    
                    Bot.sendTextMessageToUsers(s);
                  //  (menuSchedule[6].Screen as UserControlText).text = String.Empty;
                }
            }
            listView.UnselectAll();
        }

        
    }
}
