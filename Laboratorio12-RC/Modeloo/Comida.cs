using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeloo
{
    public class Comida
    {
        public string nombre;
        int carbohidratos;
        int proteinas;
        int grasas;

        public Comida(string nombre, int carbohidratos, int proteinas, int grasas)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.proteinas = proteinas;
            this.grasas = grasas;
        }

        public override string ToString()
        {
            return $"{nombre} (carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas}, calorias: {Calorias()})";
        }

        public int Calorias()
        {
            return (4 * carbohidratos + 4 * proteinas + 9 * grasas);
        }
    }
}
