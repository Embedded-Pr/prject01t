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
using System.Xml.Serialization;

namespace WpfDemo_1
{
    public partial class MainWindow : Window
    {
        public string SL = "NotOK";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ShowPage(UserControl page)
        {
            MainContent.Content = page;
        }

        public void BackToMain()
        {
            MainContent.Content = null;
        }

        private void LoginData(object sender, RoutedEventArgs e)
        {
            //ShowPage(new Page_Login());
        }

        private void Button_Archived(object sender, RoutedEventArgs e)
        {
            if (SL == "OK")
            {
                //ShowPage(new Archived());
            }
            else
            {
                MessageBox.Show("Not Login Yet Sorry!");
            }
        }

        private void VD(object sender, RoutedEventArgs e)
        {
            if (SL == "OK")
            {
                //ShowPage(new Variable_Domains());
            }
            else
            {
                MessageBox.Show("Not Login Yet Sorry!");
            }
        }

        private void AppFormula(object sender, RoutedEventArgs e)
        {
            if (SL == "OK")
            {
                //ShowPage(new ApplicationFormual());
            }
            else
            {
                MessageBox.Show("Not Login Yet Sorry!");
            }
        }

        private void ArrccrCacule(object sender, RoutedEventArgs e)
        {
            if (SL == "OK")
            {
                //ShowPage(new ArrCcrCalcule());
            }
            else
            {
                MessageBox.Show("Not Login Yet Sorry!");
            }
        }
    }
}