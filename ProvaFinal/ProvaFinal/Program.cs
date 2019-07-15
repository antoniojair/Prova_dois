using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;


namespace ProvaFinal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o nome para busca...");
            string name = Console.ReadLine();
            tester(name);
            jsonConverte(name);

            Console.ReadKey();
        }

        public static void tester(string name) {

            ProductList product = new ReadXML("PRODUCTS.xml").products(name);
            foreach (Product p in product.All()) {
                Console.WriteLine("Produto: {0} - {1} - {2}", p.id, p.name, p.price);
            }


        }

        public static void jsonConverte(string name) {
            ProductList product = new ReadXML("PRODUCTS.xml").products(name);
            string json = new JavaScriptSerializer().Serialize(product);
            Console.WriteLine(json);
            System.IO.File.WriteAllText("PESQUISA.jason", json);
        }

    }
}

