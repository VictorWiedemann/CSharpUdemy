using System;
using CSharpUdemy;

namespace CSharpUdemy
{
    public class OrderProcessor
    {
        public readonly IShippingCalculator _shippingCalculator;


        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed");


            order.shipment = new Shipment()
            {
                //CompressedStack = _shippingCalculator.CalculateShipping(Order),
                //ShippingDate = DateTime.Today.AddDays(1)
            };

        }
    }
}
