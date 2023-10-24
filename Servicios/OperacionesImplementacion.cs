using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoEntero.Servicios
{

    internal class OperacionesImplementacion : OperacionesInterfaz

    {

        public double RaizCuadrada(int opcionSeleccion)
        {

            double raizCuadrada = Math.Sqrt(opcionSeleccion);

            Console.WriteLine(raizCuadrada);

            return raizCuadrada  ;

        }
    }
}
