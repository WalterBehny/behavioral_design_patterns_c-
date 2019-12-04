using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class RealEstate : IAsset
    {
        private int estimatedValue;
        private int monthlyRent;

        public RealEstate(int estimatedValue, int monthlyRent)
        {
            this.estimatedValue = estimatedValue;
            this.monthlyRent = monthlyRent;
        }

        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
       
        public int getEstimatedValue()
        {
            return estimatedValue;
        }

        public int getMonthlyRent()
        {
            return monthlyRent;
        }
    }
}
