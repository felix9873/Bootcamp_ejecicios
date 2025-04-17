using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionObjecto
{
    public class Product
    {
        private string _name;
        private string _description;

        private decimal _price;
        private string _category;
        private string _typeProduct;

        public Product(string name, string description
            , decimal price, string typeProduct , string category)
        {
            _name = name;
            _price = price;
            _category = category;
            _description = description;
            _typeProduct = typeProduct;
        }
    }
}
