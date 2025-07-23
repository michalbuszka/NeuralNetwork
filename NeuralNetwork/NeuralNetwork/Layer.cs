using System;

namespace NeuralNetwork
{
    public class Layer
    {
        private Neuron[][] Neurons;
        public Layer(int ammountOfNeurons) 
        {
            Neurons = new Neuron[ammountOfNeurons][];
            for (int y = 0; y < Neurons.Length; y++)
            {
                Neurons[y] = new Neuron[ammountOfNeurons];
                for (int x = 0; x < Neurons.Length; x++)
                    Neurons[y][x] = new Neuron(0);
            }
        }
        public void SetNeuron (System.Windows.Point point, int value)
        {
            Neurons[(int)point.Y][(int)point.X].Value = value;
        }
    }
}
