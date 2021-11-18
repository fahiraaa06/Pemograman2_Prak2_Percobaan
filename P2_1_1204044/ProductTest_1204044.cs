using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204044
{
    class ProductTest_1204044
    {
        static void Main(String[] args)
        {
            Book_1204044 product1 = new Book_1204044("Book", "C# Object Oriented Solution", "300");
            DVD_1204044 product2 = new DVD_1204044("Eternal Sunshine of the Spotless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called {1} and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
