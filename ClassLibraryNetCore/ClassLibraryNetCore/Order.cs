using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    class Order
    {
        public int OrderId { get; set; }
        public decimal TotalValue { get; set; }

        public DateTime Date { get; set; }

        public int CustomerCustomerID { get; set; }

        private Order()
        {
            // EF
        }

        public static Order Create(int id, decimal value, DateTime date, int customerCustomerID)
        {
            return new Order
            {
                OrderId = id,
                TotalValue = value,
                Date = date,
                CustomerCustomerID = customerCustomerID
            };
        }
    }
}
