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
    public class CanvasController
    {
        private Canvas canvas; 
        public CanvasController(Canvas canvas) 
        {
            this.canvas = canvas;
        }
        public Point DrawPoint(MouseEventArgs e)
        {
            double cellWidth = canvas.ActualWidth / Settings.inputNeurons;
            double cellHeight = canvas.ActualHeight / Settings.inputNeurons;
            Point mousePos = e.GetPosition(canvas);
            int x = (int)(mousePos.X / cellWidth);
            int y = (int)(mousePos.Y / cellHeight);
            Rectangle rectangle = new Rectangle { Width = cellWidth, Height = cellHeight, Stroke = Brushes.Black, Fill = Brushes.Black };
            Canvas.SetLeft(rectangle, x * cellWidth);
            Canvas.SetTop(rectangle, y * cellHeight);
            canvas.Children.Add(rectangle);
            return new Point(x, y);
        }
    }
}
