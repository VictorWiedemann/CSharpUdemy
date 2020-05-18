using System;

namespace CSharpUdemy
{
    public class Order
    {
        public float TotalPrice { get; set; }
        
        public Shipment shipment { get; set; }
        public DateTime DatePlace { get; set; }
        public int Id { get; set; }

        public bool IsShipped
        {
            get { return shipment != null; }
        }

    }

    public class Shipment
    {

    }

}