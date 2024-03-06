using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Lab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ToDo.strList.Add(new ToDo("Eat", "15.01.2024", "No", true));
            ToDo.strList.Add(new ToDo("Work", "20.01.2024", "Moscow", false));
            ToDo.strList.Add(new ToDo("Sleep", "01.02.2024", "Sochi", true));
            DataGridCase.ItemsSource = ToDo.strList;
        }
        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            WindowCreate WinCreate = new WindowCreate();
            WinCreate.Show();
            WinCreate.Owner = this;
            DataGridCase.ItemsSource = null;
            DataGridCase.ItemsSource = ToDo.strList;
            
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {            
            ToDo.strList.Remove(ToDo.strList[DataGridCase.SelectedIndex]);
            DataGridCase.ItemsSource = null;
            DataGridCase.ItemsSource = ToDo.strList;
        }

        private void DoingCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridCase.SelectedItem == null) return;
            if (ToDo.strList[DataGridCase.SelectedIndex].DoingS == true)
            {
                ToDo.strList[DataGridCase.SelectedIndex].DoingS = false;
            }
            else ToDo.strList[DataGridCase.SelectedIndex].DoingS = true;
        }
    }
}