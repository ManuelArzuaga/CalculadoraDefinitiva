using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDefinitiva
{
    internal class Menu
    {
        /// <summary>
        /// Metodo para mostrar el menu de operaciones
        /// </summary>
        /// <returns>Retorna el valor seleccionado</returns>
        protected static int MuestraMenu()
        {
            Console.Clear(); //limpiar la consola
            Console.WriteLine("=========================================");
            Console.WriteLine("            Menu de operaciones          ");
            Console.WriteLine("=========================================");
            Console.WriteLine(" 1.Sumar");
            Console.WriteLine(" 2.Restar");
            Console.WriteLine(" 3.Multiplicar");
            Console.WriteLine(" 4.Dividir");
            Console.WriteLine(" 5.Salir");
            Console.WriteLine("=========================================");
            Console.WriteLine("Por favor, selecciona una opcion: ");

            if(int.TryParse(Console.ReadLine(),out var operacion)) // si el valor ingresado es un int
            {
                //Console.ReadLine(),out var operacion; guarda en la variable operacion lo que se ingresa por consola
                //int.TryParse(Console.ReadLine(),out var operacion) se necesita el int.tryparse para usar el Console.ReadLine(),out var operacion
   
                return operacion;
            }
            else
            {
                Console.WriteLine("Por favor, selecciona una opcion valida");
                Console.ReadLine(); //se puede usar para esperar un tiempo hasta ingresar algo por teclado, puede ser un enter
                return MuestraMenu(); //devuelve una llamada a la funcion
            }
        }
    }
}
