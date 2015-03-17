using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_2_kassakvitto.Model
{
    public class Receipt
    {
        public double DiscountRate { get; private set; }
        public double MoneyOff { get; private set; }
        public double Total { get; private set; }
        public double Subtotal {
            get { return _subtotal; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Value can not be 0 or less");
                _subtotal = value;
            }
        }

        private double _subtotal; 

        public Receipt(double subtotal)
        {
            Subtotal = subtotal;

            if (Subtotal >= 5000)
                DiscountRate = 0.15;
            else if (Subtotal >= 1000)
                DiscountRate = 0.10;
            else if (Subtotal >= 500)
                DiscountRate = 0.05;
            else
                DiscountRate = 0;

            MoneyOff = Subtotal * DiscountRate;
            Total = subtotal - MoneyOff;
        }

        public void Calculate(double subtotal)
        {
            
        }
    }
}