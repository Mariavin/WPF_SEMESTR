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
using WpfApplication1.BusinessFacade.Controls;
using WpfApplication1.BusinessFacade.Services;
using WpfApplication1.UI;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AvtorizationControl avtorizationControl;
        IControl user;
        public MainWindow()
        {
            avtorizationControl = new AvtorizationControl();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = textbox2.Text;
            var pass = textbox1.Text;
            user = avtorizationControl.Avtorize(login, pass);

            if (user is TrenerControl)
            {
                AdminPanel winTool = new AdminPanel(user);
            }
            else if (user is ClientControl)
            {

            }
            else
            {
                label1.Visibility = Visibility.Visible;
                label1.Content = "ошибка";
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            //Создание нового окна.
            AdminPanel winTool = new AdminPanel(user);
            // Назначение текущего окна владельцем.
            winTool.Owner = this;
            // Отображение окна, принадлежащего окну-владельцу.
            winTool.Show();
            mainwindow.Visibility=Visibility.Hidden;
        }
    }
}
