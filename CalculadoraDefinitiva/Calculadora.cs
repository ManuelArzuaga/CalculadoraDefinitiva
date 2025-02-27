using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDefinitiva
{
    internal class Calculadora : Menu
    {
        protected static int Calcular(int num1, int num2, int opcion)
        {
            return opcion switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 => num1 / num2,
                _ => 0


                //num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),if(num2 !=0){num1/num2) else {throw new dividebyzeroexception()}
                //nuevo tipo de switch 
                //el default se escribe _ =>
            };
        }
    }
}
