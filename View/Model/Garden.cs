using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Garden : Interfaz2
    {
        private Flower[] flowers;
        private int generation;
        private int iParentA;
        private int iParentB;

        public Garden()
        {
            flowers = new Flower[10];
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            for (int n = 0; n < 10; n++)
            {
                Flower temp = new Flower();
                flowers[n] = temp;
                flowers[n].WindowPosition = n * 80 + 40;

                // Inicialize the chromosome

                // Height between  10 to 300 
                flowers[n].SetHeight(random.Next(10, 300));

                // Flower's Color. 0-red, 1-blue, 2-yellow 
                flowers[n].SetColor(random.Next(0, 3));

                // Stem's Color. Greens... 
                flowers[n].SetStemColor(random.Next(0, 3));

                // Stem Width. between 5 to 15 
                flowers[n].SetStemWidth(random.Next(5, 15));

                // Stem Size. between 20 a 80 
                flowers[n].SetStemSize(random.Next(20, 80));

                // Size of center of flower. between 5 to 15 
                flowers[n].SetSizeCenter(random.Next(5, 15));
            }
        }

        public Flower GetFlowerByIndex(int index)
        {
            return flowers[index];
        }

        public int CountFLowers()
        {
            return flowers.Length;
        }

    }
}


