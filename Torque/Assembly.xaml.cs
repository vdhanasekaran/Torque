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
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace Torque
{
    /// <summary>
    /// Interaction logic for Assembly.xaml
    /// </summary>D:\Ramk\Bolt And Torque\Torque\Assets\3D_Models\InteractiveMeshCursor.fbx
    public partial class Assembly : Window
    {
        private const string ModelPath = "Model/Model.stl";
        public Assembly()
        {
            InitializeComponent();
            ModelVisual3D device3D = new ModelVisual3D();
            device3D.Content = Display3D(ModelPath);
            viewPort3d.Children.Add(device3D);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private Model3D Display3D(string ModelPath)
        {
            Model3D Device = null;
            try
            {
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);
                ModelImporter import = new ModelImporter();
                Device = import.Load(ModelPath);
            }
            catch(Exception E)
            {
                MessageBox.Show("Exception:" + E.StackTrace);
            }
            return Device;
        }
    }
}
