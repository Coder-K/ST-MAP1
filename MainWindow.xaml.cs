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

namespace ST_MAP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String page;
        public MainWindow()
        {

            InitializeComponent();
            //  frame1.Source = new Uri("Modules.xaml",UriKind.RelativeOrAbsolute);
          //  PagesManager();
        
        }
        
        public  void PagesManager() {
            if (new Modules().NextPage)
            {
                frame1.Content = new SemesterDetails();
            }
            else { frame1.Content =  new Modules(); }
        }

        private void AddModule(object sender, RoutedEventArgs e)
        {
            frame1.Content = new Modules();
        }
        private void SemesterDetails(object sender, RoutedEventArgs e)
        {
            frame1.Content = new SemesterDetails();
        } 
        private void Modules(object sender, RoutedEventArgs e)
        {
            frame1.Content = new ViewModules();
        }  
        private void HoursDone(object sender, RoutedEventArgs e)
        {
            frame1.Content = new PersonalHours();
        }  



        private void ChangePage(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Content) {
                case "Modules":
                    frame1.Content = new Modules();
                    MessageBox.Show("Showing Modules");
                    break;
                case "Semester":
                    frame1.Content = new SemesterDetails();
                    MessageBox.Show("Showing Semester Details");
                    break;

                default:
                    frame1.Content=new Modules();
                    break;

            }
        }

    }
}
