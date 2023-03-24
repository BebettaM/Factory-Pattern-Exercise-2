using System;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public static List<Product> Product = new List<Product>()
        {
            new Product() {Name= "Xbox", Price = 350},
            new Product() {Name= "Iphone", Price = 1000},
            new Product(){Name= "MacBook", Price= 2000},
            new Product() {Name= "Notebook", Price= 10},

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access.");
            return Product;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List Data Acess");
        }
    }
}

