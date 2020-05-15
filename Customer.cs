using System.Collections.Generic;

namespace CSharpUdemy
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public readonly List<Order> Orders;
        //instead of doing the base constructor, you can do this to init List:
        //public List<Order> Orders = new List<Order>();



        //overloaded constructors
        public Customer()
        {
            Orders = new List<Order>(); // need this generated or a null reference exception can happen.
        }

        public Customer(int id) : this()
        {
 //           this.Id = id;

        }

        public Customer(int id, string name) : this(id)
        {
//            this.Id = id;
            this.Name = name;
        }

        public void Promote()
        {
            
            //cant do this because of readonly now
            //Orders = new List<Order>();
        }


        public int CalculateRating()
        {
            return 0;
        }

    }
}