using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace ProvaFinal {
    class ReadXML {
        ProductList list = new ProductList();
        private XDocument xDoc;

        public ReadXML(string xmlFile) {
            xDoc = XDocument.Load(xmlFile);
        }

        public ProductList products(string name) {
            var query = from c in xDoc.Element("Products").Elements("Product")
                        where c.Element("Product_name").Value.ToLower().Contains(name.ToLower())
                        select c;
            foreach (XElement p in query) {
                Product product = new Product(XmlConvert.ToInt32(p.Element("Product_id").Value),
                p.Element("Product_name").Value,
                XmlConvert.ToDouble(p.Element("Product_price").Value));
                list.Add(product);
            }
            return list;
        }


    }
}
