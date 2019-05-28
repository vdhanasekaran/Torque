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
    /// Interaction logic for LoadingJoint.xaml
    /// </summary>
    public partial class LoadingJoint : Window
    {
        public LoadingJoint()
        {
            InitializeComponent();
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

            TighteningConditions tightening = new TighteningConditions();
            tightening.Show();
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
            Fastener fastener = new Fastener();
            fastener.Show();
            this.Close();
        }

        private void btnHlp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
