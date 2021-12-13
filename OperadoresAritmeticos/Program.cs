using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Aritmeticos 

            int numeroOperador = 4;


            /* Operador de Incremento - Sufixado */
            Console.WriteLine(numeroOperador++);
            Console.WriteLine(numeroOperador--);

            /* Operador de Incremento - Prefixado */
            Console.WriteLine(++numeroOperador);
            Console.WriteLine(--numeroOperador);

            /* Operações de Logica*/
            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));

            /* Operadoes Binarios */

            var soma = 4 + 5;
            var subtração = 4 - 5;
            var multiplicação = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 5;
            var multiplos = (4 + 5) + 10;

            #endregion
        }
    }
}
