using System.Windows;
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
        public MainWindow()
        {
            avtorizationControl = new AvtorizationControl();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = textbox2.Text;
            var pass = textbox1.Text;
            var userControl = avtorizationControl.Avtorize(login, pass);

            if (userControl is TrenerControl)
            {

            }
            else if (userControl is ClientControl)
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
           
           // //Создание нового окна.
           //// Trener_Panel winTool = new Trener_Panel();
           // // Назначение текущего окна владельцем.
           // winTool.Owner = this;
           // // Отображение окна, принадлежащего окну-владельцу.
           // winTool.Show();
           // mainwindow.Visibility = Visibility.Hidden;
        }
    }
}
