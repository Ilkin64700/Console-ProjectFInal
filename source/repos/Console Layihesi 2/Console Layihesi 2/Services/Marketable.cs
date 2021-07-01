using Console_Layihesi_2.Enum;
using Console_Layihesi_2.Interface;
using Console_Layihesi_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Layihesi_2.Services
{
    class Marketable : IMarketable
    {
        public List<Order> Orders { get; set ; }
        public List<Product> Products { get; set; }

        public Marketable()
        {
            List<Order> order = new List<Order>();
            List<Product> product = new List<Product>();
        }

        public void AddOrder(string productcode, int productcount)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(string name, double price, Category category, int count)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(string newname, int newcount, double newcost, Category category, string newcode)
        {
            throw new NotImplementedException();
        }

        public List<Order> RetturnOrderByDate(string date)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturByName(string productname)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnByPrice(double startprice, double endprice)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByCost(double startcost, double endcost)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByDates(string olddate, string newdate)
        {
            throw new NotImplementedException();
        }

        public List<Order> ReturnOrderByNo(string orderno)
        {
            throw new NotImplementedException();
        }

        public void ReturnOrderItem(string order, string orderproduct, int count)
        {
            throw new NotImplementedException();
        }

        public void ReturnProductItem(string orderno)
        {
            throw new NotImplementedException();
        }
    }
}
