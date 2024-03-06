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
using System.Windows.Shapes;

namespace Lab14
{
    /// <summary>
    /// Логика взаимодействия для WindowCreate.xaml
    /// </summary>
    public partial class WindowCreate : Window
    {
        public WindowCreate()
        {
            InitializeComponent();
            dateToDo.SelectedDate = new DateTime(2024, 01, 10);
            descriptionToDo.Text = "Описания нет";
            

        }

        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (dateToDo.SelectedDate == null) return;
            ToDo.strList.Add(new ToDo(titleToDo.Text, dateToDo.SelectedDate.Value.ToShortDateString(), descriptionToDo.Text, false));
            (this.Owner as MainWindow).DataGridCase.ItemsSource = null;
            (this.Owner as MainWindow).DataGridCase.ItemsSource = ToDo.strList;
            this.Close();
        }

    }
}
