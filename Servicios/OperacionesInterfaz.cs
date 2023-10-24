using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoEntero.Servicios
{
    internal interface OperacionesInterfaz
    {
        /// <summary>
        /// Método que calcula la raiz cuadrada
        /// </summary>
        /// <param name="opcionSeleccion"></param>
        /// <returns></returns>
        public double RaizCuadrada(int opcionSeleccion);
        
    }
}
