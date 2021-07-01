using Console_Layihesi_2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Layihesi_2.Models
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int ProductCount { get; set; }
        public string Code;
        private static int _codecount = 1000;

        public Product(string name,double price,Category category,int count)
        {
            _codecount++;
            Name = name;
            Price = price;
            Category = category;
            ProductCount = count;
            Code = Name.Trim().ToUpper().Substring(0, 2) + _codecount;
        }

        public override string ToString()
        {
            return $"{Code} {Name} {Price} {Category} {ProductCount}";
        }

    }
}
