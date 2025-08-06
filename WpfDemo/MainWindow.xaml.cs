using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemo.Data;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Person person = new Person
        {
            Name = "Nrmeen",
            Age = 21
        };*/
        List<Person> people=new List<Person> { 
         new Person{Name="Nrmeen",Age=21},
         new Person{Name="Aya",Age=21},
         new Person{Name="Ahmed",Age=21 }
        };
        public MainWindow()
        {
            InitializeComponent();

            /*Button myButton=new Button();
            myButton.Content = "B";

            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);

            Grid grid = (Grid)FindName("myGrid");
            grid.Children.Add(myButton);*/

            /// CONTENTCONTROL ///
            // MainContent.Content = new LoginView();

            /// DATABINDING ///
            //this.DataContext = person; 

            ListBoxNames.ItemsSource = people;
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Heyaaaa");
        }*/
        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            string personData=person.Name + " is "+person.Age +" years old";
            MessageBox.Show(personData);
        }*/
    }
}