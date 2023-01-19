using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
using MyCal;

namespace ST_MAP1
{
    /// <summary>
    /// Interaction logic for Modules.xaml
    /// </summary>
    public partial class Modules : Page
    {
        public Modules()
        {
            InitializeComponent();
        }
        public bool NextPage,Complete = false;

        /*Method to handle passoing the field information to the list */
        private void Submit_Module(object sender, RoutedEventArgs e)
        {
            // declaration of class objescts 
            MainWindow mainWindow = new MainWindow();
            var manager = new ManageModules();
            ViewModules view = new ViewModules();
            try
            {
                //checking the fields 
                if (!Complete) { CheckFields(); }
                else
                {
                    // passing field information to temporary varibles 
                    string Mcode = Code.Text.ToString();
                    string Mname = Name.Text.ToString();
                    double Mweekly = Double.Parse(Weekly.Text);
                    int Mcredits = Int32.Parse(Credits.Text);
                    {  /*
                    var holder = new List<ManageModules>()
                    {new ManageModules{ Code = Mcode,Name = Mname ,Required = Mweekly,Points =Mcredits } };
                    
                    view.ModulesDisplay.ItemsSource = holder;*/
                    }

                    double req =  Cal.SelfStudy(10,Mcredits, Mweekly);

                    // adding variables to list 
                    //new ManageModules(Mcode,Mname,req,Mcredits).AddingModule(Mcode, Mname, req, Mcredits);
                    new ManageModules(Mcode,Mname,req,Mcredits).Details.Add(new ManageModules(Mcode, Mname, req, Mcredits) { Code =Mcode, Name =Mname, Required= req,Points= Mcredits });

                    // checking if list updated 
                    if (manager.Details.Count < 0) { MessageBox.Show(" not loaded please try again "); }
                    else { MessageBox.Show(Name.Text + " Saved"); }
                }
            }
            catch (Exception)
            {

                throw;
            }
               
              
                
           
        }
        /*,ethod that handles checking all the fiels are filled out or not */
        public void CheckFields()
        {
            if ((Code.Text).Equals(string.Empty)) { MessageBox.Show("Module Code is required"); }
            else if (Name.Text == string.Empty) { MessageBox.Show("Module Name is required"); }
            else if (Weekly.Text == string.Empty) { MessageBox.Show("Class hour are required"); }
            else if (Credits.Text == string.Empty) { MessageBox.Show("Module Credits is required"); }
            else { Complete = true; }



        }
    }
}
