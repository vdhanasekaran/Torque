﻿using System;
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
    /// Interaction logic for CalculationMethod.xaml
    /// </summary>
    public partial class CalculationMethod : Window
    {
        public CalculationMethod()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Assembly assembly = new Assembly();
            assembly.Show();
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
            ProjectDetails projectDetails = new ProjectDetails();
            projectDetails.Show();
            this.Close();
        }

        private void btnHlp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
