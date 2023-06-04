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
using Wpf_dz_patternMVC.Model;

namespace Wpf_dz_patternMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        // обработчик кнопки Сохранить
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson(txtBoxName.Text, Int32.Parse(txtBoxAge.Text));
        }

        // обработчик кнопки Показать
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            Print();
        }

        // обработчик кнопки Найти Имя
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var list_new = controller.GetSearchPerson(txtBoxSearch.Text);
            listBoxNames.Items.Clear();
            foreach (var item in list_new)
            {
                listBoxNames.Items.Add(item);
            }
        }

        // контекстное меню Удалить
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var element = listBoxNames.SelectedItem;
                controller.RemovePerson((Model.Person)element);
                Print();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Вы не выбрали элемент. \nВыберите нужное имя!");
            }
        }

        // контекстное меню Очистить список
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            listBoxNames.Items.Clear();
        }

        // метод для вывода списка на экран
        void Print()
        {
            listBoxNames.Items.Clear();
            foreach (var item in controller.GetAllPerson())
            {
                listBoxNames.Items.Add(item);
            }
        }
    }
}
