
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
           

            opcionSeleccion = menuInterfaz.MostrarYRecogerSeleccion();

            double raizCuadrada = Math.Sqrt(opcionSeleccion);

            Console.WriteLine(raizCuadrada);
           
             
        }

         
        
    }
}