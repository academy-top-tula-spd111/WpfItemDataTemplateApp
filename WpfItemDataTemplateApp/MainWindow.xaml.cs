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

namespace WpfItemDataTemplateApp
{
    public class User
    {
        public string? Name { set; get; }
        public DateTime BirthDay { set; get; }
        public bool Married { set; get; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { set; get; }
        public MainWindow()
        {
            InitializeComponent();
            Users = new()
            {
                new(){ Name = "Bob", BirthDay = new DateTime(1999, 6, 6), Married = false },
                new(){ Name = "Joe", BirthDay = new DateTime(2001, 8, 5), Married = true },
                new(){ Name = "Sam", BirthDay = new DateTime(1992, 12, 7), Married = true },
                new(){ Name = "Leo", BirthDay = new DateTime(2000, 11, 10), Married = false },
            };

            usersList.ItemsSource = Users;
        }
    }
}
