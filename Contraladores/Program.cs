
using CuadradoEntero.Servicios;
using System.Reflection.Metadata.Ecma335;

namespace CuadradoEntero.Contraladores
{
    /// <summary>
    /// Clase principal 
    /// 241023 - ebp
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método principal del programa
        /// 231023
        /// </summary>
        /// <param name="args"></param>
        /// <author>ebp</author>
        public static void Main(string[] args)
        {

            MenuInterfaz menuInterfaz = new MenuImplementacion();
            OperacionesInterfaz operacionInterfaz = new OperacionesImplementacion();

            int opcionSeleccion;

            double raizCuadrada;

            opcionSeleccion = menuInterfaz.MostrarYRecogerSeleccion();

            raizCuadrada = operacionInterfaz.RaizCuadrada(opcionSeleccion);

           if (raizCuadrada * raizCuadrada == opcionSeleccion)
            {
                Console.WriteLine("El cuadrado perfecto de " + opcionSeleccion + " es " + raizCuadrada + " elevado a " + raizCuadrada);

            }
            else
            {
                Console.WriteLine("El número " + opcionSeleccion + " no tiene un cuadrado perfecto");
            }
        }

         
        
    }
}