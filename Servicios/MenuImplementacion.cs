using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoEntero.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MostrarYRecogerSeleccion()
        {
            int opcionSeleccion;

            Console.WriteLine("Introduzca un número para conocer si el número se puede expresar como el cuadrado de otro número entero");
            opcionSeleccion = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccion;


        }
    }
}
