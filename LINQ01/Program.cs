using LINQ.Models;
using LINQ.DataSources;

namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Q01
            var result = Source.ProductList
                        .Where(P => P.Category == "seafood")
                        .Select(P => new { P.ProductName, P.UnitPrice });
            foreach(var items in result)
            {
                Console.WriteLine(items);
            }

            
        }
    }
}
