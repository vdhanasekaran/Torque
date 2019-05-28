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

namespace Torque
{
    /// <summary>
    /// Interaction logic for ProjectDetails.xaml
    /// </summary>
    public partial class ProjectDetails : Window
    {
        public ProjectDetails()
        {
            InitializeComponent();
             
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            CalculationMethod calculationMethod = new CalculationMethod();
            calculationMethod.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHlp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
