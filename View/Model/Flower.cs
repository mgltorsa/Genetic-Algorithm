using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Flower
    {

        // Window position
        private int windowPosition;

        // Adaptation level.
        private double adaptation;


        // We create the Flower's Chromosome

        //Index's:
        // 0: height
        // 1: Flower's Color
        // 2: Stem's Color
        // 3: Stem's Width
        // 4: Stem's Size
        // 5: Size of Flower's Center.


        public int[] chromosome = new int[6];

        public int WindowPosition { get => windowPosition; set => windowPosition = value; }
        public double Adaptation { get => adaptation; set => adaptation = value; }

        public Flower()
        {
            // 
            // TODO
            // 
        }
    }
}

