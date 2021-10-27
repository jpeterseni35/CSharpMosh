using System.Collections.Generic;
using System;

namespace CSharpMosh
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();  //  readonly protects the list so that it errors if something tries to change it.

        // Constructors
        public Customer(int id)
        // : this()  // only use this if you have to
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // only use this if you have to

        {

            this.Name = name;
        }
        public void Promote()
        {
            
            // ....
        }        


    }
}
