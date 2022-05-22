using Microsoft.Win32;
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
        BitmapImage bt;

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
                if(bt != null)
                    Persons.Add(new Person(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxYear.Text), textBoxCity.Text, bt));
                else
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
            //BigImg.Visibility = Visibility.Hidden;
        }

       /* private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                BigImg.Source = new BitmapImage(fileUri);
                bt = new BitmapImage(fileUri);
                BigImg.Visibility = Visibility.Visible;
            }

        }*/
    }
}
