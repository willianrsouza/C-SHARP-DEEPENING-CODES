using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Logicos AND & OR 

            /* AND */
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            /* OR */
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);

            #endregion

            Console.Read();
        }
    }
}
