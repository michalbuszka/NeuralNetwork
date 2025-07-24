using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork
{
    public class Neuron
    {
        public int Value { get; set; }
        public Neuron ()
        {
            
        }
        public Neuron (int Value)
        {
            this.Value = Value;
        }
    }
}
