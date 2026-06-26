using System.DirectoryServices.ActiveDirectory;
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

namespace WpfDemo_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button myBotton  = new Button();
            //myBotton.Content = "B";


            //Grid.SetRow(myBotton,3);
            //Grid.SetColumn(myBotton, 4);

            //Grid mygrid = (Grid) FindName("mygrid");
            //myGrid.Children.Add(myBotton);
        }

        private void Button_Archived(object sender, RoutedEventArgs e)
        {
           Archived arch1 = new Archived();
            LoginFrame.Navigate(arch1);

        }
        private void LoginData(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show("Emain Address : " + Environment.NewLine + "Your PassKey : ");
            Page_Login loginPage = new Page_Login();
            LoginFrame.Navigate(loginPage);
            //var win = new Window();
            //win.Content = new Page_Login();
        }
        public void VD(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("it has been clicked");

            myGrid.Children.Clear();
            myGrid.RowDefinitions.Clear();
            myGrid.ColumnDefinitions.Clear();
            myGrid.Children.Add(new Variable_Domains());

        }
        
    }
}