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

            //Q02
            var result2 = Source.ProductList.Select(P => new { P.ProductName });
            foreach (var name in result2)
            {
                Console.WriteLine(name);
            }

            //Q03
            var result3 = Source.ProductList
                        .OrderBy(P=>P.UnitPrice)
                        .Select(P => new { P.ProductName, P.UnitPrice });
            foreach (var items in result3)
            {
                Console.WriteLine(items);
            }


        }
    }
}
