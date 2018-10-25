using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeloo
{
    public class ListaComida
    {
        List<Comida> comidas;

        public ListaComida()
        {
            comidas = new List<Comida>();
        }
        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            int i = 1;
            Console.WriteLine("Ingrese el numero de la comida que decee eliminar");
            foreach(Comida c in comidas)
            {
                Console.WriteLine($"{i}. {c.nombre}\n Calorias: {c.Calorias()}");
            }
            int pos = Int32.Parse(Console.ReadLine())-1;
            comidas.RemoveAt(pos);
        }
    }
}
