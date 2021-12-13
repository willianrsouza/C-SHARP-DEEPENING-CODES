using System;

namespace EstruturasCondicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estruturas de Condição - IF & ELSE

            /* Receber Valor */

            Console.WriteLine("Digitar Nota: ");
            var entradaNota = Console.ReadLine();

            /* Conversão utlizando 'Parse' */
            var nota = int.Parse(entradaNota);

            if (nota >= 70)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 40)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            #endregion

            #region  Estrutuas de Condição - Switch Case

            Console.WriteLine("Bem Vindo, empresa X : ");

            Console.WriteLine("1 - Contratação Plano ");
            Console.WriteLine("2 - Reclamação");
            Console.WriteLine("3 - Boleto");
            Console.WriteLine("4 - Sair ");

            var op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.WriteLine("Informações Plano");
                    break;

                case "2":
                    Console.WriteLine("Quadro de Reclamações");
                    break;

                case "3":
                    Console.WriteLine("Boleto - Imprimir");
                    break;

                case "4":
                    Console.WriteLine("Exit");
                    break;

            }

            #endregion
        }
    }
}
