using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simcar
{
    public class car
    {
        
        
        public int tipo { get; set; } //tipo de carro 1 liviano 2 camioneta 3 pesada
        public int peso { get; set; } //peso del carro
        public int velmax { get; set; } //velocidad maxima del carro
        public int maxacel { get; set; } //maxima aceleracion del carro
        public int actgas { get; set; } // gasolina actual
        public int velact { get; set; } // velocidad actual
        public int acelact { get; set; }// acelelarcion actual actual
        public car(int tipo, int peso, int velmax, int maxacel, int actgas) { }


    }


}
