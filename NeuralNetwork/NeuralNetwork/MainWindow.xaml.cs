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

namespace NeuralNetwork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDrawing = false;
        private CanvasController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller= new CanvasController(drawingArea);
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isDrawing = true;
            //pozycja startowa myszki
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
                return;
            Point point = controller.DrawPoint(e);
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            controller.Clear();
        }
    }
}