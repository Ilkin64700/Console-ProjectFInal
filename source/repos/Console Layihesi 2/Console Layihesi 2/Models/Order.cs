using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Layihesi_2.Models
{
    class Order
    {
        private static int _count { get; set; }
        public int OrderNo;
        public double Cost { get; set; }
        List<OrderItem> OrderItems { get; set; }
        public string Date { get; set; }


        public Order(int no,double cost,List<Product>products,int year,int month,int day)
        {
            _count++;
            OrderNo = _count;
            Cost = cost;
            List<OrderItem> orderItems = new List<OrderItem>();
            Date = day.ToString()+" "+ month.ToString()+" "+ year.ToString();
        }

    }
}
