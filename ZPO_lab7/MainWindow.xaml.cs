using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Persons { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Persons = new ObservableCollection<Person>();
            personList.ItemsSource = Persons;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Persons.Add(new Person(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxYear.Text), textBoxCity.Text));
            }
            catch
            {
                MessageBox.Show("Error!");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxYear.Clear();
            textBoxCity.Clear();
        }
    }
}
