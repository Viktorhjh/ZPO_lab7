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

namespace ZPO_lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> list = new List<Person>();        
        public MainWindow()
        {
            InitializeComponent();
            list.Add(new Person("qwe","asd",54, "zxc"));
            list.Add(new Person("rty", "fgh", 98, "vbn"));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                list.Add(new Person(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxYear.Text), textBoxCity.Text));
            }
            catch
            {
                MessageBox.Show("Error!!");
            }

            listView.ItemsSource = list;
            listView.Items.Refresh();
        }
    }
}
