﻿using System;
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
using System.Windows.Shapes;
using WpfApplication1.BusinessFacade.Controls;

namespace WpfApplication1.UI
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        IControl Trener;
        public AdminPanel(IControl trener)
        {
            InitializeComponent();
            Trener = trener;
        }

        private void AddProgram_Click(object sender, RoutedEventArgs e)
        {
            //Создание нового окна.
            AddingProgram winTool = new AddingProgram(Trener);
            // Назначение текущего окна владельцем.
            winTool.Owner = this;
            // Отображение окна, принадлежащего окну-владельцу.
            winTool.Show();
          
        }
    }
}
