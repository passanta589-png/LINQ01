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

            //Q04
            var result4 = Source.ProductList
                        .Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);
            foreach (var price in result4)
            {
                Console.WriteLine(price);
            }

            //Q05
            var result05 = Source.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");
            foreach(var stock in result05)
            {
                Console.WriteLine(stock);
            }

            //Q06
            var Proudect1 = Source.ProductList.Select(P => new { P.ProductName, P.UnitPrice, StockStatus = P.UnitsInStock > 0 ? "Available" : "Out of Stock" });
            foreach(var item in Proudect1)
            {
                Console.WriteLine(item);
            }

            //Q07
            var q7 = Source.ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");

            foreach (var line in q7)
                Console.WriteLine(line);

            #region 08
            //Q08

            var result08 = Source.ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
             foreach (var sort in result08)
                Console.WriteLine(sort);
            #endregion

            #region 09
            //Q09
            var result09 = Source.ProductList.Where(P => P.Category == "Beverages").OrderByDescending(P => P.UnitsInStock).Select(P => new { P.ProductName, P.UnitsInStock });
            foreach(var sort2 in result09)
            {
                Console.WriteLine(sort2);
            }
            #endregion
        }

    }
}
