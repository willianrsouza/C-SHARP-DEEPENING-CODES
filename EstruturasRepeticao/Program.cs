using System;

namespace EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  Estrutuas de Repetição - For

            Console.WriteLine("Digite Sequencia de Números");

            var numerosTexto = Console.ReadLine();
            var numeros = numerosTexto.Split(' ');

            Console.WriteLine("Numeros: ");

            /* Inicialização - Condição* - Incremento*/
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            #endregion

            #region  Estrutuas de Repetição - While

            var contador = 0;

            while (contador < numeros.Length)
            {
                Console.WriteLine(numeros[contador]);
            }

            #endregion

            #region  Estrutuas de Repetição - Foreach

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
