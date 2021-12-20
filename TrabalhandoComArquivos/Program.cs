using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            #region File

            var file = @"pasta\texto.txt";

            if (!File.Exists(file))
            {
                File.Create(file);
            }

            var fileInfo = new FileInfo(file);

            Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de Atualização: {fileInfo.LastWriteTime}");

            #endregion

            Console.ReadKey();

        }
    }
}
