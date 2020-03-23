using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        private Customer()
        {
            // EF
        }

        public static Customer Create(int id, string name, string city)
        {
            return new Customer
            {
                CustomerId = id,
                Name = name,
                City = city
            };
        }

    }
}
