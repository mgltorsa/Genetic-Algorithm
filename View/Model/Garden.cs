using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Garden
    {
        private Flower[] flowers;
        private int generation;
        private int iParentA;
        private int iParentB;

        public Garden()
        {
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            for (int n = 0; n < 10; n++)
            {
                Flower temp = new Flower();
                flowers[n] = temp;
                flowers[n].WindowPosition = n * 80 + 40;

                // Inicializamos el cromosoma con valores al azar 

                // La altura va de 10 a 300 
                flowers[n].chromosome[0] = random.Next(10, 300);

                // El color de la flor. 0-rojo, 1-azul, 2-amarillo 
                flowers[n].chromosome[1] = random.Next(0, 3);

                // El color del tallo. Diferentes tonos de verde 
                flowers[n].chromosome[2] = random.Next(0, 3);

                // El ancho del tallo. De 5 a 15 
                flowers[n].chromosome[3] = random.Next(5, 15);

                // El tamano de la flor. De 20 a 80 
                flowers[n].chromosome[4] = random.Next(20, 80);

                // El tamano del centro de la flor. De 5 a 15 
                flowers[n].chromosome[5] = random.Next(5, 15);
            }
        }

    }
} 
    

