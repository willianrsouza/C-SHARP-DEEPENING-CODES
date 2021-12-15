using System;
using System.Collections.Generic;
using System.Linq;

namespace EstruturasArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            /* Inicializando com a capacidade */
            var numbersCapacidade = new int[10];

            /* Inicializando, definindo valores */
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCapacidade[i] = numbers[i];
            }

            var numberString = "0 1 2 3 4 5 6 7 8 9";
            var numbersArray = numberString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);

            #endregion Arrays

            #region Listas

            /* Incializando uma lista com valores pré-definidos */
            var list = new List<int> { 0, 1, 2, 3, 4 };

            /* Incializando uma lista a partir de um Array */
            var listFromArray = new List<int>(numbers);

            /* Adicionando um elemento*/
            list.Add(5);

            /* Adicionando uma Lista */
            list.AddRange(new List<int> { 6, 7 });

            /* Adicionando um Array */
            list.AddRange(new int[] { 8, 9 });

            /* Buscando o tamanho da List */
            var count = list.Count;

            /* Verificando se existe o valor referenciado */
            var contains = list.Contains(14);

            /* Revertendo a ordem da List */
            list.Reverse();

            /* Interar sobre, realizar impressão */
            list.ForEach(l => Console.WriteLine("Lista Reversa: " + l));

            /* Lista Ordenada */
            list.Sort();
            list.ForEach(l => Console.WriteLine("Lista Ordenada: " + l));

            /* Removendo */
            list.Remove(4);

            /* Removendo utilizando regra */
            list.RemoveAll(i => i > 5);
            #endregion Listas

            #region LINQ

            var students = new List<StudentModel>
            {
                new StudentModel(1, "Luis", "4964984+98498", 100),
                new StudentModel(1, "Carlos", "3978984+98498", 35),
                new StudentModel(1, "Lucas", "2574984+98498", 85),
                new StudentModel(1, "Maria", "68984+98498", 70),
                new StudentModel(1, "Susana", "8564+98498", 75)
            };

            /* Existe algo nesta List ? */
            var any = students.Any();

            /* Existe algo nesta List com 'Grade' == 100 ? */
            var any100 = students.Any(s => s.Grade == 100);

            /* Existe um 'id' que possui o valor '1' */
            var single = students.Single(s => s.Id == 1);

            /* Existe um 'id' que possui o valor '1', caso não exista retorne valor padrão */
            var singleOrDefault = students.SingleOrDefault(s => s.Id == 1);

            /* Retorna o primeiro Elemento da lista que possui o valor referenciado*/
            var first = students.First(s => s.FullName == "Luis");

            /* Retorna o primeiro aluno com o nome referenciado, ou retorna valor padrão*/
            var fistOrDefault = students.FirstOrDefault(s => s.FullName == "Luis");

            /* Ordenar alunos por nota*/
            var orderByGrade = students.OrderBy(s => s.Grade);

            /* Ordenação especifica*/
            var orderByGradeDescending = students.OrderByDescending(s => s.Grade);

            /* Buscar por expressão boolean*/
            var approvedStudents = students.Where(s => s.Grade >= 70);

            /* Selecionando somente uma propriedade */
            var grades = students.Select(s => s.Grade);

            /* Selecionando todas as referencias de uma propriedade */
            var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);

            /* Somar todas propridades propriedade */
            var sum = students.Sum(s => s.Grade);

            /* Selecionar menor valor da propriedade */
            var min = students.Min(s => s.Grade);

            /* Buscar maior valor da propriedade */
            var max = students.Max(s => s.Grade);

            #endregion LINQ

            Console.ReadKey();

        }
    }
}
