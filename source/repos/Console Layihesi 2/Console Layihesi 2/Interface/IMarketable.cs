using Console_Layihesi_2.Enum;
using Console_Layihesi_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Layihesi_2.Interface
{
    interface IMarketable
    {
        List<Order> Orders { get; set; }
        List<Product>Products { get; set; }
        void AddOrder(string productcode,int productcount);
        void ReturnOrderItem(string order,string orderproduct,int count);
        void ReturnProductItem(string orderno);
        List<Order> ReturnOrderByDates(string olddate,string newdate);
        List<Order> RetturnOrderByDate(string date);
        List<Order> ReturnOrderByCost(double startcost, double endcost);
        List<Order> ReturnOrderByNo(string orderno);
        void AddProduct(string name,double price,Category category,int count);
        void EditProduct(string newname,int newcount, double newcost,Category category,string newcode);
        List<Product> ReturnByCategory(Category category);
        List<Product> ReturnByPrice(double startprice,double endprice);
        List<Product> ReturByName(string productname);



            
        
    }
}
