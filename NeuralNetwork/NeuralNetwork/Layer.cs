using System;
using System.Text;
using System.Windows.Media.Converters;

namespace NeuralNetwork
{
    public class Layer
    {
        private Neuron[] Neurons;
        private int Length;
        private int Width;
        public Layer(int length)
        {
            this.Length = length;
            Neurons = new Neuron[length];
            for (int i = 0; i < length; i++) 
                Neurons[i] = new Neuron();
        }
        public Layer(int width, int height)
        {
            this.Width = width;
            this.Length = width * height;
            Neurons = new Neuron[Length];
            for (int i = 0; i < Length; i++)
                Neurons[i] = new Neuron();
        }
        public void SetNeuron(int x, int y, int value)
        {
            Neurons[y * Width + x].Value = value;
        }
        public void SetNeuron(int index, int value)
        {
            Neurons[index].Value = value;
        }
        public String Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < Length; i++)
                stringBuilder.Append(Neurons[i].Value + " ");
            return stringBuilder.ToString();
        }
    }
}
