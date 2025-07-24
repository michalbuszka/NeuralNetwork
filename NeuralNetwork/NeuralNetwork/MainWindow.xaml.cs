using System.IO;
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
        private Layer inputLayer;
        public MainWindow()
        {
            InitializeComponent();
            inputLayer = new Layer(Settings.inputNeurons, Settings.inputNeurons);
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
            inputLayer.SetNeuron((int)point.X, (int)point.Y, 255);
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            String plik = "plik.txt";
            File.WriteAllText(plik, inputLayer.Display());
            controller.Clear();
            NumberIntegerUpDown.ClearValue(Xceed.Wpf.Toolkit.IntegerUpDown.ValueProperty);
        }
    }
}