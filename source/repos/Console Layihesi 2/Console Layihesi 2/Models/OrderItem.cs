using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Layihesi_2.Models
{
    class OrderItem
    {
        public int OrderItemNo;
        private int _orderitemcount { get; set; }
        public Product OrderItemProduct { get; set; }
        public int OrderItemCount { get; set; }

        public OrderItem(int orderitemno,Product orderitemproduct,int orderitemcount)
        {
            _orderitemcount++;
            OrderItemCount = _orderitemcount;
            OrderItemProduct = orderitemproduct;
            OrderItemCount = orderitemcount;
        }
    }
}
