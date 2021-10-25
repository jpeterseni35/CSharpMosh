using System.Collections.Generic;
using System;

namespace CSharpMosh
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // Constructors
        public Customer()
        {

            Orders = new List<Order>();
            // Constructor using object inintialization

        }
        public Customer(int id)
            : this()  // only use this if you have to
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // only use this if you have to

        {

            this.Name = name;
        }



    }
}
