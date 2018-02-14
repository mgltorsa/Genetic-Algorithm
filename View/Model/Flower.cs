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


        private int[] chromosome = new int[6];

        public int WindowPosition { get => windowPosition; set => windowPosition = value; }
        public double Adaptation { get => adaptation; set => adaptation = value; }

        public Flower()
        {
            // 
            // TODO
            // 
        }

        public int GetStemColor()
        {
            return chromosome[2];
        }

        public void SetStemColor(int color)
        {
            chromosome[2] = color;
        }

        public int GetHeight()
        {
            return chromosome[0];
        }

        public void SetHeight(int height)
        {
            chromosome[0] = height;
        }

        public int GetColor()
        {
            return chromosome[1];
        }

        public void SetColor(int colorF)
        {
            chromosome[1] = colorF;
        }

        public int GetStemWidth()
        {
            return chromosome[3];
        }

        public void SetStemWidth(int width)
        {
            chromosome[3] = width;
        }

        public int GetStemSize()
        {
            return chromosome[4];
        }

        public void SetStemSize(int size)
        {
            chromosome[4] = size;
        }

        public int GetSizeCenter()
        {
            return chromosome[5];
        }

        public void SetSizeCenter(int size)
        {
            chromosome[5] = size;
        }



    }
}

