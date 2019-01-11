using System;
using NorthWind.Dal;
using NorthWind.Entities;

namespace NF.ConsoleApp.newDb
{
    internal class Program
    {
        private static void Main()
        {
            using (var context  = new NorthWindContext())
            {
                Console.WriteLine("Proporciona el nombre de la categoria a agregar:>>");
                var categoryName = Console.ReadLine();
                var newCategory = new Category
                {
                    CategoryName = categoryName
                };

                context.Categories.Add(newCategory);
                var affectedRecords = context.SaveChanges();
                Console.WriteLine($"{affectedRecords} registro guardado en la base de datos.>>");
                Console.WriteLine();

                Console.WriteLine("Categorias en la base de datos:");
                foreach (var category in context.Categories)
                {
                    Console.WriteLine($"{category.CategoryId}, {category.CategoryName}>>");
                }

                Console.ReadKey();
            }
        }
    }
}
