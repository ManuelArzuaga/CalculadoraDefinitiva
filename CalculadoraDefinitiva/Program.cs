namespace CalculadoraDefinitiva
{
    internal class Program : Calculadora //hereda de calculadora
    {
        private static void Main(string[] args)
        {
            //debe ser un ejecutable, no debe tener la logica del programa  
            int num1, num2, operacion = 0; //declarar varias varibales en una misma linea. solo operacion tiene asignado un valor
            
            while(operacion != 5)
            {
                operacion = MuestraMenu();
                //program hereda de calculadora y calculadora hereda de menu, por lo tanto en program puedo usar las funciones y metodos de calculadora y de menu
                
                if(operacion == 5)
                {
                    Console.WriteLine("Gracias por usar la calculadora");
                    break;
                }

                Console.WriteLine("\nIngrese el primer numero: ");
                while(!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Ingrese un numero valido: ");
                }

                Console.WriteLine("\nIngrese el segundo numero: ");

                while (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Ingrese un numero valido: ");
                }

                Console.WriteLine(num2 == 0 && operacion == 4 ? "No se puede dividir por cero" : $"el resultado es {Calcular(num1, num2, operacion)}\n");
                Console.WriteLine("Pulse enter para realizar una nueva operacion");
                Console.ReadLine(); // espera a que se presione enter para volver a mostrar el menu
            }
        }
    }
}
